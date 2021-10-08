using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp075.Business.Model.BusinessObjects
{
    public class Client
    {
        private String name;
        public int Id { get; set; }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    name = "Feld darf nicht leer sein.";
                }
            }
        }
    }
}
