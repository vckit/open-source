using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hpapp.Model
{
    public partial class Employee
    {
        public string GetFullName
        {
            get
            {
                return $"{FirstName} {LastName} {MiddleName}";
            }
            set
            {
                GetFullName = value;
            }
        }
    }
}
