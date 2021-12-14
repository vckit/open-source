using hpapp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hpapp.Model
{
    public partial class District
    {
        public int GetCount
        {
            get
            {
                return AppData.db.Polyclinic.Count(item => item.ID == IDPolyclinic);
            }
        }

        public int GetCountStaf
        {
            get
            {
                var collection = AppData.db.Polyclinic.Where(item => item.ID == IDPolyclinic).ToList();
                int count = 0;
                foreach (var item in collection)
                {
                    count += item.CountSupportStaf;
                }
                return count;
            }
        }

       
    }
}
