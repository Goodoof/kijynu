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
    /// Логика взаимодействия для New_Request.xaml
    /// </summary>
    public partial class New_Request : Window
    {
        public New_Request()
        {
            InitializeComponent();
        }

        public void Send_request_Click(object sender, RoutedEventArgs e)
        {
            string model = DeviceModel.Text;
            string type = DeviceType.Text;
            string description = Description.Text;

            demoEntities content = new demoEntities();

            if(model.Length == 0 || type.Length == 0 || description.Length == 0)
            {
                MessageBox.Show("Поля не могут быть пустыми", "Ошибка");
                return;
            }

            request req = new request {
                startDate = DateTime.Now,
                cmptTechModel = model,
                cmptTechType = type,
                status_id = 1,
                Description = description,
                client_id = ViewModel.user_id,
            };
            try
            {
                content.request.Add(req);
                content.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() ,"Ошибка");
                return;
            }
            MessageBox.Show("Заявка создана", "Успех");
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        public void GoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
