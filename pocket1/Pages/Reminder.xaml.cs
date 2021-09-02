using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace pocket1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Reminder : Page
    {
        public Reminder()
        {
            this.InitializeComponent();
        }
        private void Send(object sender, RoutedEventArgs e)
        {
            SendEmail();
        }
        public async Task SendEmail()
        {
            string username = Name.Text;
            string useremail = Email.Text;
            string userphone = Phone.Text;
            string subject = Subject.Text;
            string usermessage = Message.Text;

            // Message.Text = username + "Thank you, message received";
            EmailMessage em = new EmailMessage();
            em.To.Add(new EmailRecipient("adeniyi,ladenegan@triosstudent.com"));
            string emailbody = "This message is from " + username + "as regards" + subject + "";
            em.Body = emailbody;
            await EmailManager.ShowComposeNewEmailAsync(em);
        }
    }
}










