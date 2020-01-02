using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rtlcollectionview { 

[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArabicMainPage : ContentPage
    {
        IEnumerable ItemsSource1;
        public ArabicMainPage()
        {
            InitializeComponent();         
            BindingContext = this;
            ItemsSource1 = new List<MobileNasoption>() {
                new MobileNasoption{ItemTitle="دليل الاتصال", ItemImageURL="a1.png" },
                new MobileNasoption{ItemTitle="حسابى", ItemImageURL="a2.png" },
                new MobileNasoption{ItemTitle="تغيير الحاله", ItemImageURL="a3.png" },
                new MobileNasoption{ItemTitle=" مميزات", ItemImageURL="a4.png" },
                new MobileNasoption{ItemTitle="خروح", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle="موافقه الازونات ", ItemImageURL="a6.png" },
                new MobileNasoption{ItemTitle="طلب اجازات", ItemImageURL="a7.png" },                           
                new MobileNasoption{ItemTitle="تسجيل الدخول", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle="مميزاتى", ItemImageURL="a2.png" },
   
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

        private void NavigateToOtherLanguge(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}