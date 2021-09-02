using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocket1
{
        public class CityItem
    {
        public int id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string founder
        {
            get;
            set;
        }

        public string capital
        {
            get;
            set;
        }

        public string population
        {
            get;
            set;
        }

        public string image
        {
            get;
            set;
        }

        public string area
        {
            get;
            set;
        }

        public string attraction
        {
            get;
            set;
        }

        public string mayor
        {
            get;
            set;
        }

        public string favfood
        {
            get;
            set;
        }

        public static ObservableCollection<CityItem> CitiesList()
        {
            ObservableCollection<CityItem> cities = new ObservableCollection<CityItem>()
            {
                new CityItem()
                {
                    id = 1,
                    name = "Markham",
                    founder= "James Bond",
                    mayor = "Jack Bauer",
                    capital = "Stoufville",
                    population ="200,000",
                    image = "/Assets/img/c1.png",
                    area= "21000sqm",
                    attraction = "ApplesOrchards",
                    favfood = "Applepie"

                },

                 new CityItem()
                {
                    id = 2,
                    name = "Ottawa",
                    founder= "Daniel Makawi",
                    mayor = "Dick Tracy",
                    capital = "Jacksonville",
                    population ="320,000",
                    image = "/Assets/img/c2.png",
                    area= "17000sqm",
                    attraction = "Parliament hill",
                    favfood = "Mac and Cheese"

                },

                  new CityItem()
                {
                    id = 3,
                    name = "Montreal",
                    founder= "Duke Peterson",
                    mayor = "Monte Cristo",
                    capital = "Quebec",
                    population ="300, 000",
                    image = "/Assets/img/c3.png",
                    area= "15000sqm",
                    attraction = "Lightsville",
                    favfood = "Fish Fillet"

                },

                   new CityItem()
                {
                    id = 4,
                    name = "Niagara",
                    founder= "Nick Norton",
                    mayor = "Angel mcFalls",
                    capital = "Valleyville",
                    population ="210,000",
                    image = "/Assets/img/c4.png",
                    area= "23000sqm",
                    attraction = "The Niagara falls",
                    favfood = "Fish fillets"

                },

                    new CityItem()
                {
                    id = 5,
                    name = "YellowKnife",
                    founder= "Knave Queen",
                    mayor = "Souly Strips",
                    capital = "Axeville",
                    population ="80,000",
                    image = "/Assets/img/c5.png",
                    area= "23000sqm",
                    attraction = "Snowy mountains",
                    favfood = "small chops"

                },

                     new CityItem()
                {
                    id = 6,
                    name = "Toronto",
                    founder= "Tory Mackenzie",
                    mayor = "Little Richard",
                    capital = "Dundas",
                    population ="2000000",
                    image = "/Assets/img/c6.png",
                    area= "20000sqm",
                    attraction = "Scotia Arena",
                    favfood = "Milk Shakes"

                },

                      new CityItem()
                {
                    id = 7,
                    name = "Edmonton",
                    founder= "Eddy Montana",
                    mayor = "Captain Cooke",
                    capital = "Edgecombe",
                    population ="160,000",
                    image = "/Assets/img/c7.png",
                    area= "16000sqm",
                    attraction = "University of Edmonton",
                    favfood = "Fish and Chips"

                },

            new CityItem()
                {
                    id = 8,
                    name = "Etobicoke",
                    founder= "Michael Douglas",
                    mayor = "Doug Ford",
                    capital = "Cookesville",
                    population ="220,000",
                    image = "/Assets/img/c8.png",
                    area= "16000sqm",
                    attraction = "Cooke river",
                    favfood = "Coca Cola"

                },


            new CityItem()
                {
                    id = 9,
                    name = "British Columbia",
                    founder= "Bill Cosby",
                    mayor = "Bing Cosby",
                    capital = "Columbus",
                    population ="300,000",
                    image = "/Assets/img/c9.png",
                    area= "12000sqm",
                    attraction = "Hearts Museum",
                    favfood = "Chicken"
                },

             new CityItem()
                {
                    id = 10,
                    name = "Markham",
                    founder= "Timothy Mackenzie",
                    mayor = "John Tory",
                    capital = "Whitchurch",
                    population ="210,000",
                    image = "/Assets/img/c10.png",
                    area= "8000sqm",
                    attraction = "Markham Festival",
                    favfood = "Ice cream"

                },

              new CityItem()
                {
                    id = 11,
                    name = "Bowmanville",
                    founder= "Adeniyi Bond",
                    mayor = "Mohammed Alli",
                    capital = "Longworth",
                    population ="240,000",
                    image = "/Assets/img/c11.png",
                    area= "9000sqm",
                    attraction = "king Stadium",
                    favfood = "Pizza"

                },

               new CityItem()
                {
                    id = 12,
                    name = "Oakville",
                    founder= "Mark Twain",
                    mayor = "Tom Sawyer",
                    capital = "Oakgrad",
                    population ="220,000",
                    image = "/Assets/img/c12.png",
                    area= "800sqm",
                    attraction = "Oak Forest",
                    favfood = "Oak juice"

                },

                new CityItem()
                {
                    id = 13,
                    name = "Mississauga",
                    founder= "Mick Jagger",
                    mayor = "Gloria Estefan",
                    capital = "MissyVille",
                    population ="300,000",
                    image = "/Assets/img/c13.png",
                    area= "10000sqm",
                    attraction = "LakeMisty",
                    favfood = "Potpouri"

                },

             new CityItem()
                {
                    id = 14,
                    name = "Victoria",
                    founder= "Manny Pacquiao",
                    mayor = "Eddy Grant",
                    capital = "Vickville",
                    population ="270,000",
                    image = "/Assets/img/c14.png",
                    area= "7000sqm",
                    attraction = "Parks",
                    favfood = "Taco"

                },
              new CityItem()
                {
                    id = 15,
                    name = "St Johns",
                    founder= "James Band",
                    mayor = "Jimmy Cliff",
                    capital = "Stouville",
                    population ="250,000",
                    image = "/Assets/img/c15.png",
                    area= "5000sqm",
                    attraction = "Seasides",
                    favfood = "Oystermeals"

                }

            };
            return cities;
        }
    }
}
