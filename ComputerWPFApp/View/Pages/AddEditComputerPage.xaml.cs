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
using Microsoft.Win32;
using System.IO;

namespace ComputerWPFApp.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditComputerPage.xaml
    /// </summary>
    public partial class AddEditComputerPage : Page
    {
        public AddEditComputerPage(Компьютер comp)
        {
            InitializeComponent();
            if (comp == null)
            {
                _Computer = new Компьютер();
            }
            else
            {
                _Computer = comp;
            }
            DataContext = _Computer;
        }
        private Компьютер _Computer;
        private static string FileName { get; set; }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            if (_Computer.Код == 0) DatabaseComputerEntities.GetContext().Компьютер.Add(_Computer);
            if (FileName != null)
            {
                byte[] bData = File.ReadAllBytes(FileName);
                _Computer.Изображение = bData;
            }
            DatabaseComputerEntities.GetContext().SaveChanges();
            PageNavigator.Back();
            MessageBox.Show("Информация сохранена!");
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            RAMComboBox.Items.Add("DDR2");
            RAMComboBox.Items.Add("DDR4");
            RAMComboBox.Items.Add("DDR3");

            TypeDisk.Items.Add("HDD");
            TypeDisk.Items.Add("SSD");

            ManufacturerComboBox.ItemsSource = DatabaseComputerEntities.GetContext().Производители.ToList();
            VideocardComboBox.ItemsSource = DatabaseComputerEntities.GetContext().Видеокарта.ToList();
            ProcComboBox.ItemsSource = DatabaseComputerEntities.GetContext().Процессор.ToList();
        }

        private void ImgClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FileName = openFileDialog.FileName;
                MessageBox.Show("Изображение получено!");
            }
        }
    }
}
