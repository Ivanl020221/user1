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

namespace SalaryV1.Users.Manager.coefficient
{
    /// <summary>
    /// Логика взаимодействия для ManagmentCoefficient.xaml
    /// </summary>
    public partial class ManagmentCoefficient : Page
    {
        Model.DataBaseConnectionModel ConnectionModel = new Model.DataBaseConnectionModel();

        public ManagmentCoefficient()
        {
            InitializeComponent();
            this.Loaded += this.LoadPage;
        }

        private void LoadPage(object sender, RoutedEventArgs e)
        {
            try
            {
                this.coefficientGrid.
             ItemsSource =
             ConnectionModel.
             factors.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.HelpLink, MessageBoxButton.OK, MessageBoxImage.Error);
            }
         
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            try
            {
                ConnectionModel.SaveChanges();
                MessageBox.Show("Сохранено", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно добавить, проверте правильность введенных данных", ex.HelpLink,MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
