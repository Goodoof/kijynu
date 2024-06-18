using demo.Windows;
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

namespace demo.Pages
{
    /// <summary>
    /// Логика взаимодействия для User_buttons.xaml
    /// </summary>
    public partial class User_buttons : Page
    {

        public User_buttons()
        {
            InitializeComponent();
        }

        private void CloseWindow()
        {
            Window parent = Window.GetWindow(this);
            parent.Close();
        }

        private void New_Request_Click(object sender, RoutedEventArgs e)
        {
            New_Request new_request = new New_Request();
            new_request.Show();
            CloseWindow();
        }
        private void Request_list_Click(object sender, RoutedEventArgs e)
        {
            Request_list request_list = new Request_list();
            request_list.Show();
            CloseWindow();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.user_type = 0;
            ViewModel.user_id = 0;
            Auth auth = new Auth();
            auth.Show();

            CloseWindow();

        }
    }
}
