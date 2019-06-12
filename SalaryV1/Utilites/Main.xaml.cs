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
using System.Windows.Shapes;

namespace SalaryV1.Utilites
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void SetTitle(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            if (sender is Page page)
            {
                this.Title = $"Распределение зарплат - {page.Title}";
            }
        }

        private void ExitThis(object sender, RoutedEventArgs e)
        {
            if (MessageBox.
                Show(
                "Вы уверены, " +
                "что хотите выйти?",
                "Выход",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) ==
                MessageBoxResult.Yes)
            {
                Main main = new Main();
                main.Show();
                this.Close();
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }
    }
}
