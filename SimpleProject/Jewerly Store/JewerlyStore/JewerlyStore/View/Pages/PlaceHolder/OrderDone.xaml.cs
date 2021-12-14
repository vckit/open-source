using JewerlyStore.DB;
using JewerlyStore.View.Pages.FunctionsWithData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JewerlyStore.View.Pages.PlaceHolder
{
    /// <summary>
    /// Логика взаимодействия для OrderDone.xaml
    /// </summary>
    public partial class OrderDone : Page
    {
        private Check check;
        public OrderDone(Check check)
        {
            InitializeComponent();
            this.check = check;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }
        
        private void btnGetCheck_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GetCheckPage(check));
        }
    }
}
