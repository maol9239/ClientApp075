using De.HsFlensburg.ClientApp075.Business.Model.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp075.Logic.Ui.Wrapper
{
    public class ClientCollectionViewModel : List<ClientViewModel>
    {
        private ClientCollection myClients;
       public ClientCollectionViewModel()
       {
           myClients = new ClientCollection();

            foreach (Client client in myClients)
            {
                this.Add(new ClientViewModel(client));
            }
       }
    }
}
