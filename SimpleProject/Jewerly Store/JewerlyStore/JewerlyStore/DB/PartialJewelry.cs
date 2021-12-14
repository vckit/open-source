using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewerlyStore.DB
{
    partial class Jewelry
    {
        public string JewelryGet
        {
            get
            {
                return JewName + ", " + Material + ", " + Category.Title + ", " + Pice; 
            }
        }

        public string JewelryCheckGet
        {
            get
            {
                return "Наименование: " + JewName + ", Категория: " + Category.Title;
            }
        }

        public string Price
        {
            get
            {
                return Pice + " рублей";
            }
        }
    }
}
