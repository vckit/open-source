using hpapp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hpapp.Model
{
    public partial class Patient
    {
        public int Count
        {
            get
            {
                return AppData.db.Patient.Count(item => item.IDPolyclinic == Polyclinic.ID);
            }
        }
        public double Procent
        {
            get
            {
                double count = Count;
                double countDis = District.Count;
                double resutl = (count / countDis);
                return resutl * 100;
            }
        }
    }
}
