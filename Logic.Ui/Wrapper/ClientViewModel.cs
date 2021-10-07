using System;

namespace De.HsFlensburg.ClientApp075.Logic.Ui.Wrapper
{
    public class ClientViewModel
    {
        private Client myClient = new Client();
        public ClientViewModel(Client client)
        {
            this.myClient = client;
        }
        public ClientViewModel()
        {

        }
        public int Id
        {
            get
            {
                return myClient.Id;
            }
            set
            {
                myClient.Id = value;
            }
        }
        public String Name
        {
            get
            {
                return myClient.Name;
            }

            set
            {
                myClient.Name = value;
            }
        }
    }
}
