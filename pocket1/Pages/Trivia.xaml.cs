using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace pocket1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Trivia : Page
    {
        public Trivia()
        {
            this.InitializeComponent();
        }

        int Tripcounts = 0;
        int Total = 0;
        private void Check(object sender, RoutedEventArgs e)
        {

            Random random = new Random();
            int randnum1 = random.Next(100, 125);
            int randnum2 = random.Next(100, 125);

            int newcost = 0;
            string l1 = randnum1.ToString();
            string l2 = randnum2.ToString();

            // dice1.Text = randnum1.ToString();
            pic1.Source = new BitmapImage(new Uri("ms-appx:///Assets/luc/" + l1 + ".png"));
            pic2.Source = new BitmapImage(new Uri("ms-appx:///Assets/luc/" + l2 + ".png"));

            if (tswitch.IsOn == true && randnum1 == randnum2)
            {
                newcost = (randnum1 + randnum2) * 2;
            }
            else
            {
                newcost = randnum1 + randnum2;
            }

            if (pb.Maximum >= Tripcounts)
            {
                pb.Value = Tripcounts;
            }

            if (Tripcounts == pb.Maximum && Total >= 5000)
            {
                mybuttons.Visibility = Visibility.Collapsed;
                pic1.Visibility = Visibility.Collapsed;
                pic2.Visibility = Visibility.Collapsed;
                fdestination.Visibility = Visibility.Visible;
                tcost.Visibility = Visibility.Collapsed;

                totalestimate.Text = "This is the amount you have spent so " +
               "far in your retirements savings " + "" + "$" + "" + Total.ToString();
                trips.Text = "This is" + " " + "Trip number: " + Tripcounts;


                if (Total >= 5000)
                {
                    fdestination.Source = new BitmapImage(new Uri("ms-appx:///Assets/cloth/ret.png"));
                }


            }
            //dice2.Text = randnum2.ToString();

            tcost.Text = "This is the amount this trip will cost you" + " " + " " + "$" + (newcost).ToString() ;
            Tripcounts++;

            

            Total += newcost;

           
        }

    }
}















