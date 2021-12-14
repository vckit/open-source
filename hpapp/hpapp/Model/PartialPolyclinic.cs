using hpapp.Context;
using System.Linq;

namespace hpapp.Model
{
    public partial class Polyclinic
    {
        public string GetName
        {
            get
            {
                return $"{NumberPolyclinic} {AddressPolyclinic} {NSWHE} {NSWSSE}";
            }
        }

        public int CountSpec
        {
            get
            {
               return NSWHE + NSWSSE;
            }
        }
    }
}
