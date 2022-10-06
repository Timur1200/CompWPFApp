using ComputerWPFApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            CBoxSearch.Items.Add("Поиск");
            CBoxSearch.Items.Add("Производитель");
            CBoxSearch.Items.Add("Тип накопителя");

            CBoxSearch.SelectedIndex = 0;
        }
        List<Компьютер> _listAllComp;
        
        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            _listAllComp = DatabaseComputerEntities.GetContext().Компьютер.ToList(); 
            LViewMat.ItemsSource = _listAllComp;
        }


        private void LViewMat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        void Search()
        {
            if (TBoxSearch.Text.Length == 0)
            {
                LViewMat.ItemsSource = _listAllComp;
                return;
            }

            if (CBoxSearch.SelectedIndex ==  0) LViewMat.ItemsSource = _listAllComp;
            else if (CBoxSearch.SelectedIndex == 1)
            {
                var a = DatabaseComputerEntities.GetContext().Компьютер.Where(q=>q.Производители.Имя.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
                LViewMat.ItemsSource = a;
            }
            else if (CBoxSearch.SelectedIndex == 2)
            {
                var a = DatabaseComputerEntities.GetContext().Компьютер.Where(q => q.ТипНакопителяДанных.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
                LViewMat.ItemsSource = a;
            }
        }
        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Search();
        }

        private void CBoxSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Search();
        }
    }
}
