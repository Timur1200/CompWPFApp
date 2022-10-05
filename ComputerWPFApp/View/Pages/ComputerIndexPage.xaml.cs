using ComputerWPFApp.Model;
using ComputerWPFApp.Servis;
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
    /// Логика взаимодействия для ComputerIndexPage.xaml
    /// </summary>
    public partial class ComputerIndexPage : Page
    {
        public ComputerIndexPage()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            PageNavigator.MainFrame.Navigate(new AddEditComputerPage(null));
        }

        private void DelClick(object sender, RoutedEventArgs e)
        {

        }
        private void EditClick(object sender, RoutedEventArgs e)
        {   if(DGridServis.SelectedItem == null)
            {
                MessageBox.Show("Нужно выбрать запись!");
                return;
            }
            PageNavigator.MainFrame.Navigate(new AddEditComputerPage(DGridServis.SelectedItem as Компьютер));
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DGridServis.ItemsSource = DatabaseComputerEntities.GetContext().Компьютер.ToList();
            }
            catch
            {
                MessageBox.Show("Возникли проблемы с подключением к БД!");
            }
        }
    }
}
