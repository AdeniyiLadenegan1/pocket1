using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();

            clothItems_ = ClothItem.ClothesList();
            this.DataContext = ClothItems;
        }

        private ObservableCollection<ClothItem> clothItems_; //variable
        public ObservableCollection<ClothItem> ClothItems
        {
            get
            {
                return clothItems_;
            }

            set
            {
                clothItems_ = value;
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Root myWeather = await OpenWeatherMapProxy.GetWeather(20.0, 30.0);
            string icon = String.Format("http://openweathermap.org/img/w/{0}.png", myWeather.weather[0].icon);
            Img.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
            Txt.Text = myWeather.name + " - " + ((((double)myWeather.main.temp) - 32) / 3.6) + " - " + myWeather.weather[0].description;
        }
     
    }
}




    