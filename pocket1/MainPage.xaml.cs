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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace pocket1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Doors.Navigate(typeof(Pages.Home));
        }

        private void OpenPage1(object sender, RoutedEventArgs e)
        {
            Doors.Navigate(typeof(Pages.Home));
        }
        private void OpenPage2(object sender, RoutedEventArgs e)
        {
            Doors.Navigate(typeof(Pages.City));
        }
        private void OpenPage3(object sender, RoutedEventArgs e)
        {
            Doors.Navigate(typeof(Pages.Locations));
        }

        private void OpenPage4(object sender, RoutedEventArgs e)
        {
            Doors.Navigate(typeof(Pages.Trivia));
        }

        private void OpenPage5(object sender, RoutedEventArgs e)
        {
            Doors.Navigate(typeof(Pages.Reminder));
        }

        private void OpenPage6(object sender, RoutedEventArgs e)
        {
            Doors.Navigate(typeof(Pages.Journey));
        }

    }

}

