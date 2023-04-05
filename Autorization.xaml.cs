using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = $@"Data Source=BUGURT\SQLEXPRESS;Initial Catalog=Worldskills2;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();

                var login = LoginTextBox.Text;
                var password = PasswordTextBox.Text;

                var adapter = new SqlDataAdapter();
                var table = new DataTable();

                var queryString = $"SELECT name, password FROM Users WHERE name = '{login}' AND password = '{password}'";
                var command = new SqlCommand(queryString, conn);

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Contains(login) && table.Rows.Contains(login))
                {
                    Console.WriteLine("Test pass");
                }
                else
                {
                    Console.WriteLine("Test failed");
                }

            }
        }
    }
}
