using System;

namespace WpfApp2.Model
{
    public partial class Student
    {
        public string GetPhoto
        {
            get
            {
                return $"{Environment.CurrentDirectory}\\images\\{Photo}";
            }
            set
            {
                Photo = value;
            }
        }
    }
}
