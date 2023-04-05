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

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class ManufacturerAddingPage : Page
    {
        public ManufacturerAddingPage()
        {
            InitializeComponent();
        }

        private void Next_Page_Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ManufacturerPage());
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
