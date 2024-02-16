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

namespace BaranovSize41
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void TextLog_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextPass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GuestButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ProductPage(null));
            TextLog.Text = "";
            TextPass.Text = "";
        }

        private async void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            string login = TextLog.Text;
            string password = TextPass.Text;

            if(login == "" || password =="")
            {
                MessageBox.Show("Есть пустые поля");
            }

            User user = BaranovSize41Entities1.GetContext().User.ToList().Find(p => p.UserLogin == login && p.UserPassword == password);
            if(user != null) 
            {
                Manager.MainFrame.Navigate(new ProductPage(user));
                TextLog.Text = "";
                TextPass.Text = "";
            }
            else
            {
                MessageBox.Show("Ввудены неверные данные");
                EnterButton.IsEnabled = false;
                await Task.Delay(10000);
                EnterButton.IsEnabled = true;
            }
        }
    }
}
