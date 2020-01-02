using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rtlcollectionview
{
    public class MobileNasoption
    {
        public string ItemTitle { get; set; }
        public string ItemImageURL { get; set; }

    }
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        IEnumerable ItemsSource1;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            ItemsSource1 = new List<MobileNasoption>() {
                new MobileNasoption{ItemTitle="Directory", ItemImageURL="a1.png" },
                new MobileNasoption{ItemTitle="My Profile", ItemImageURL="a2.png" },
                new MobileNasoption{ItemTitle="Change Approvel Request", ItemImageURL="a3.png" },
                new MobileNasoption{ItemTitle="Benefit Items", ItemImageURL="a4.png" },
                new MobileNasoption{ItemTitle="My Leavs", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle="Time permisions approval ", ItemImageURL="a6.png" },
                new MobileNasoption{ItemTitle="Expense sheet", ItemImageURL="a7.png" },
                new MobileNasoption{ItemTitle="My Time permisions", ItemImageURL="a8.png" },
                new MobileNasoption{ItemTitle="Attendance Tracking ", ItemImageURL="a9.png" }
              
            };

        }
        protected override void OnAppearing()
        {
            CollectionView.ItemsSource = ItemsSource1;

        }

        private void ShowIndicator()
        {
        }

        private void HideIndicator()
        {
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void GridDisplay_Clicked(object sender, EventArgs e)
        {
        }


        private void NavigateToArabic(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ArabicMainPage());

        }
    }
}
