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

namespace SalaryV1.Users.Manager.Tast
{
    /// <summary>
    /// Логика взаимодействия для TaskList.xaml
    /// </summary>
    public partial class TaskList : Page
    {
        Model.DataBaseConnectionModel ConnectionModel = new Model.DataBaseConnectionModel();

        List<Model.tasks> tasks;

        List<Model.executor> executors;

        List<Model.status_task> statuses;

        public TaskList()
        {
            InitializeComponent();
            LoadData();
            this.statuses = ConnectionModel.status_task.ToList();
            this.statuses.Add(new Model.status_task { name = "Все статусы" });
            this.Status.ItemsSource = this.statuses.OrderBy(i => i.id_status).ToList();
            this.executors = ConnectionModel.executor.ToList();
            this.executors.Add(new Model.executor { LastName = "Все исполнители" });
            this.Users.ItemsSource = this.executors.OrderBy(i => i.id_executor).ToList();
            LoadData();
        }

        public void LoadData()
        {
            this.tasks = ConnectionModel.tasks.ToList();
            if (Users.SelectedItem is Model.executor exec && Users.SelectedIndex >0)
            {
                this.tasks = tasks.Where(i => i.executor_id == exec.id_executor).ToList();
            }
            if (Status.SelectedItem is Model.status_task status && Status.SelectedIndex > 0)
            {
                this.tasks = tasks.Where(i => i.status_id == status.id_status).ToList(); 
            }
            this.TasksList.ItemsSource = this.tasks;
        }

        private void SelectFilter(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
