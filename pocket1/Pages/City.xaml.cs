using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
    public sealed partial class City : Page
    {
        public City()
        {
            this.InitializeComponent();
        }

        private async void GetMyLocation_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var geolocator = new Geolocator();
            var position = await geolocator.GetGeopositionAsync();

            var mapLocation = await MapLocationFinder.FindLocationsAtAsync(position.Coordinate.Point);
            if (mapLocation.Status == MapLocationFinderStatus.Success)
            {
                MyLocation.Text = mapLocation?.Locations?[0].Address.FormattedAddress + " " + "this is your beautiful city";
                fcity.Source = new BitmapImage(new Uri("ms-appx:///Assets/img/c15.png"));
            }
            else
            {
                MyLocation.Text = "Location not found";
            }
        }

        private async void MyMap_Loaded(object sender, RoutedEventArgs e)
        {
            if (MyMap.Is3DSupported)
            {
                MyMap.Style = MapStyle.Aerial3DWithRoads;

                MyMap.MapServiceToken = "ick3V5VExSjiX6STzdVd~TdxvQZDQqJLwnjMsXG65eA~As25-MmXcCKKusrM310D9hWLSwzjGuyq41lMPGj4hcoOwcHUoEEVUA_dbbGkGVed";

                BasicGeoposition geoPosition = new BasicGeoposition();
                geoPosition.Latitude = 27.175015;
                geoPosition.Longitude = 78.248979;

                Geopoint myPoint = new Geopoint(geoPosition);

                MapIcon myPOI = new MapIcon { Location = myPoint, Title = "My Position", 
                    NormalizedAnchorPoint = new Point(0.5, 1.0), ZIndex = 0 };
                myPOI.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx://Assets/pin.png"));
                MyMap.MapElements.Add(myPOI);
                MyMap.Center = myPoint;
                MyMap.ZoomLevel = 10;

                MapScene mapScene = MapScene.CreateFromLocationAndRadius(new Geopoint(geoPosition), 500, 150, 70);
                await MyMap.TrySetSceneAsync(mapScene);
            }
        }

       


    }

}



    

