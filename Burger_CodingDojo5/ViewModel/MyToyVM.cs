using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Burger_CodingDojo5.ViewModel
{
    public class MyToyVM
    {
        public MyToyVM(string name, BitmapImage pic)
        {
            Name = name;
            Pic = pic;
        }

        public MyToyVM(string ageRecommendation, string name, BitmapImage pic)
        {
            AgeRecommendation = ageRecommendation;
            Name = name;
            Pic = pic;
        }

        public string AgeRecommendation { get; set; }
        public string Name { get; set; }
        public BitmapImage Pic { get; set; }
        public ObservableCollection<MyToyVM> Toys { get; set; }

        public void AddToys(MyToyVM toy)
        {
            if (Toys == null)
                Toys = new ObservableCollection<MyToyVM>();

            Toys.Add(toy);
        }
    }
}
