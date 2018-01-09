using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Burger_CodingDojo5.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {

        RelayCommand<MyToyVM> buyBtnClickedCmd;

        public ObservableCollection<MyToyVM> MyToys { get; set; }
        public ObservableCollection<MyToyVM> MyWishlist { get; set; }

        public RelayCommand<MyToyVM> BuyBtnClickedCmd
        {
            get
            {
                return buyBtnClickedCmd;
            }

            set
            {
                buyBtnClickedCmd = value; RaisePropertyChanged();
            }
        }

        private MyToyVM selectedToy;

        public MyToyVM SelectedToy
        {
            get { return selectedToy; }
            set { selectedToy = value; RaisePropertyChanged(); }
        }


        public MainViewModel()
        {
            //Instanziierungen
            MyToys = new ObservableCollection<MyToyVM>();
            MyWishlist = new ObservableCollection<MyToyVM>();

            DemoData();

            //Button Click
            BuyBtnClickedCmd = new RelayCommand<MyToyVM>(BuyButtonClicked, IsBuyButtonEnabled);
        }

        private bool IsBuyButtonEnabled(MyToyVM toy)
        {
            return true;
        }

        private void BuyButtonClicked(MyToyVM toy)
        {
            MyWishlist.Add(toy);
        }

        public void DemoData()
        {
            //Overview in left Listbox
            MyToys.Add(new MyToyVM("My Lego", new BitmapImage(new Uri("Images/Lego.PNG", UriKind.Relative))));
            MyToys.Add(new MyToyVM("My Playmobil", new BitmapImage(new Uri("Images/Playmobil.PNG", UriKind.Relative))));

            MyToys[0].AddToys(new MyToyVM("8+", "Imperial Ship", new BitmapImage(new Uri("Images/imperialShip.PNG", UriKind.Relative))));
            MyToys[1].AddToys(new MyToyVM("4-10", "Pirate Ship", new BitmapImage(new Uri("Images/pirateShip.PNG", UriKind.Relative))));
        }
    }
}