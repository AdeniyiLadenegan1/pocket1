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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace pocket1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Locations : Page
    {
        private ObservableCollection<CityItem> cityItems_; //variable
        public ObservableCollection<CityItem> CityItems
        {
            get
            {
                return cityItems_;
            }

            set
            {
                cityItems_ = value;
            }
        }

        public Locations()
        {
            this.InitializeComponent();
            cityItems_ = CityItem.CitiesList();
            this.DataContext = CityItems;
        }

        private void CityItemGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}


