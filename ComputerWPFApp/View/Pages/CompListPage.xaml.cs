using ComputerWPFApp.Model;
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

namespace ComputerWPFApp.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CompListPage.xaml
    /// </summary>
    public partial class CompListPage : Page
    {
        public CompListPage()
        {
            InitializeComponent();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            LViewMat.ItemsSource = DatabaseComputerEntities.GetContext().Компьютер.ToList();
        }
    }
}
