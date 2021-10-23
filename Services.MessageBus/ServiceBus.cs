﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace De.HsFlensburg.ClientApp075.Services.MessageBus
{
    public class ServiceBus : IServiceBus
    {
        private static volatile ServiceBus instance;
        private static object syncRoot = new Object();
        private Dictionary<Type, List<WeakReferenceAction>> references = new Dictionary<Type, List<WeakReferenceAction>>();

        #region Singleton
        private ServiceBus() { }

        public static ServiceBus Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new ServiceBus();
                        }
                    }
                }
                return instance;
            }
        }
        #endregion Singleton

        public void Register<TNotification>(object listener, Action<TNotification> action)
        {
            Type messageType = typeof(TNotification);
            if (!references.ContainsKey(messageType))
            {
                references.Add(messageType, new List<WeakReferenceAction>());
                WeakReferenceAction actionReference = new WeakReferenceParameterAction<TNotification>(listener, action);
                references[messageType].Add(actionReference);
            }
        }

        public void Send<TNotification>(TNotification notification)
        {
            Type messageType = typeof(TNotification);
            List<WeakReferenceAction> weakReferenceActions = references[messageType];
            foreach (WeakReferenceAction wra in weakReferenceActions)
            {
                if (wra is WeakReferenceAction<TNotification>)
                {
                    ((WeakReferenceParameterAction<TNotification>)wra).Execute(notification);
                }
                else
                {
                    wra.Execute();
                }
            }
        }

        public void Unregister<TNotification>(object listener)
        {
            bool isLocked = false; 
            try
            {
                Monitor.Enter(references, ref isLocked);
                foreach (Type targetType in references.Keys)
                {
                    foreach (WeakReferenceAction wra in references[targetType])
                    {
                        if (wra.Target == listener)
                        {
                            wra.Unload();
                        }
                    }
                }
            }
            finally
            {
                if (isLocked)
                {
                    Monitor.Exit(references);
                }
            }
        }
    }
}