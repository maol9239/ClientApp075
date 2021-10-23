using De.HsFlensburg.ClientApp075.Business.Model.BusinessObjects;
using De.HsFlensburg.ClientApp075.Logic.Ui.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace De.HsFlensburg.ClientApp075.Logic.Ui.Wrapper
{

    public class ClientViewModel : ViewModelBase<Client>
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
                return Model.Id;
            }
            set
            {
                Model.Id = value;
            }
        }
        public string Name
        {
            get
            {
                return Model.Name;
            }
            set
            {
                Model.Name = value;
            }
        }

        public override void NewModelAssigned()
        {
            throw new NotImplementedException();
        }
    }
}
