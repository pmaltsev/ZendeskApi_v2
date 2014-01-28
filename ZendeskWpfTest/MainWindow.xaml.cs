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
using ZendeskApi_v2.Models.Constants;
using ZendeskApi_v2.Models.Tickets;
using ZendeskApi_v2;


namespace ZendeskWpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ZendeskApi api = new ZendeskApi(https://surfer123.zendesk.com/api/v2, "surfer123@yandex.ru", "");
            var apiToken = new ZendeskApi(APIURL.Text, "surfer123@yandex.ru", ""); 

            var ticket = apiToken.Tickets.CreateTicket(new Ticket()
            {
                Subject = "my printer is on fire",
                Comment = new Comment() { Body = "HELP" },
                Priority = TicketPriorities.Urgent
            });
        }
    }
}
