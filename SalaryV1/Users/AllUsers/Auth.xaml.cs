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

namespace SalaryV1.Users.AllUsers
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        Model.DataBaseConnectionModel ConnectionModel = new Model.DataBaseConnectionModel();

        public Auth()
        {
            InitializeComponent();
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            if (ConnectionModel.manager.Where(i => i.login == log.Text && i.password == pass.Password).Count() > 0)
            { NavigationService.Navigate(new Users.Manager.Main.MainPage()); return; }

            if (ConnectionModel.executor.Where(i => i.login == log.Text && i.password == pass.Password).Count() > 0)
            { NavigationService.Navigate(new Users.Executor.Main.MainPage()); return; }

            MessageBox.Show("Не верный логин или пароль", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
