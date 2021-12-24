namespace WpfApp2.Model
{
    public partial class Group
    {
        public string GetName
        {
            get
            {
                return $"{Code} {Department.Title}";
            }
            set
            {
                GetName = value;
            }
        }
    }
}
