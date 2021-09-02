using NPOI.SS.Formula.Functions;
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
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace pocket1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Journey : Page
    { 
        
        public Journey()
        {
            this.InitializeComponent();

          
        }


        private void CaloriesBurnt(object sender, RoutedEventArgs e)
    

        {
            double Hours = Int32.Parse(hours.Text);
            double Kilometer = Int32.Parse(kilometer.Text);
            double GBW = Int32.Parse(gbw.Text);
           // double HK = Int64.Parse(cb.Text);

           

            result.Text =( (Hours * Kilometer)/GBW).ToString() +"K/CAL" + " " + " " + "is the value of Calories you burnt today";
            
           
        }

        public void DistTravel(object sender, RoutedEventArgs e)

        {
            try
            {
                int number = Int32.Parse(hours.Text);

                number *= 10;

                result.Text = number.ToString() +"KM" + " " + " " + "is the distance traveled";
            }
            catch
            {
                result.Text = "Syntax Error";
            }
        }

        private void NewRun(object sender, RoutedEventArgs e)

        {

            double number = Int32.Parse(hours.Text);


            if (number < 2)
            {
                result.Text = "Not Applicable";

            }
            else
            {

                Boolean prime = false;
                while (prime == false)

                {

                    number++;
                    prime = true;
                    for (int i = 2; i < number; i++)
                    {

                        if (number % i == 0)
                        {
                            prime = false;
                            break;
                        }
                        if (prime == true)
                        {
                            result.Text = "It is advisable you run" + " " +( (number + 2)/3).ToString() + " " +  "" +"km more";
                        }

                    }

                }
            }
        }

        private void BMD(object sender, RoutedEventArgs e)

        {

            int num2 = Int32.Parse(mynum2.Text);
            int num3 = Int32.Parse(mynum3.Text);

            result2.Text ="Congrats, you have shed a total of" + (100* (num3 - num2)).ToString() + "" + "grams today";
        }




        private void CreditRun(object sender, RoutedEventArgs e)

        {

            int num2 = Int32.Parse(mynum2.Text);
            int num3 = Int32.Parse(mynum3.Text);

            result2.Text = "The total credit you have this run is" + " " + (num2 * num3).ToString() + "" + "kts";
        }

        private void FITNESS(object sender, RoutedEventArgs e)

        {

            double num2 = Int32.Parse(mynum2.Text);
            double num3 = Int32.Parse(mynum3.Text);
            double answer = 1;
            for (int i = 0; i < num3; i++)
            {
                answer *= (num2)/0.5;
            }
            result2.Text = "Today, you are fitter by" + " " + "" + Math.Round(answer, 2, MidpointRounding.ToEven).ToString() + " " + "%" ;
        }
    }   
}
    

