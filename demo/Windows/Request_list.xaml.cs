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

namespace demo.Windows
{
    /// <summary>
    /// Логика взаимодействия для Request_list.xaml
    /// </summary>
    public partial class Request_list : Window
    {
        public Request_list()
        {
            InitializeComponent();

            var requests = demoEntities.GetContext().request
                .Where(x => x.client_id == ViewModel.user_id)
                .Select(x => new { x.User.fio, x.Status.status1, x.startDate, x.cmptTechModel, x.cmptTechType, x.Description, x.dateOfComplete }).ToList();


            myDataGrid.ItemsSource = requests;
        }

    }
}
