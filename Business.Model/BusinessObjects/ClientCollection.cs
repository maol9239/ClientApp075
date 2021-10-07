using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp075.Business.Model.BusinessObjects
{
    public class ClientCollection : List<Client>
    {
        public ClientCollection()
        {
            Client client1 = new Client();
            client1.Id = 345;
            client1.Name = "Samson";
            this.Add(client1);
        }
     
    }
}