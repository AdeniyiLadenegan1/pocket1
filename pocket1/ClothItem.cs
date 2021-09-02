using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocket1
{
    public class ClothItem
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

        public string image
        {
            get;
            set;
        }

        public string cost
        {
            get;
            set;
        }

        public static ObservableCollection<ClothItem> ClothesList()
        {
            ObservableCollection<ClothItem> clothes = new ObservableCollection<ClothItem>()
            {
                new ClothItem()
                {
                    id = 1,
                    name = "Tshirts",
                    image = "/Assets/cloth/Dad.png",
                    cost = "$150",

                },

                 new ClothItem()
                {
                    id = 1,
                    name = "Fallwear",
                    image = "/Assets/cloth/fallwear.png",
                    cost = "$200",

                },

                  new ClothItem()
                {
                    id = 1,
                    name = "winterOverall",
                    image = "/Assets/cloth/hood.png",
                    cost = "$250",

                },

                   new ClothItem()
                {
                    id = 1,
                    name = "neckwarmer",
                    image = "/Assets/cloth/turtleneck.png",
                    cost = "$260",

                },

                    new ClothItem()
                {
                    id = 1,
                    name = "scarf",
                    image = "/Assets/cloth/scarf.png",
                    cost = "$50",

                },

                     new ClothItem()
                {
                    id = 1,
                    name = "Jacket",
                    image = "/Assets/cloth/summ1.png",
                    cost = "$300",

                }
            };

            return clothes;
        }
    }
}

