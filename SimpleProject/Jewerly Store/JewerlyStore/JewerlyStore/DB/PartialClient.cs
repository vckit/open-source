using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewerlyStore.DB
{
    partial class Client
    {
        public string FullName
        {
            get
            {
                return LastName + " " + FirstName + " " + SecondName;
            }
        }
    }
}
