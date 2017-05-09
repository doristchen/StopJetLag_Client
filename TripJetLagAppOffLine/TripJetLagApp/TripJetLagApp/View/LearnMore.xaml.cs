using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TripJetLagApp.ViewModel;

namespace TripJetLagApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnMore : TabbedPage
    {
        InfluenceViewModel InfluenceViewModel =
           new InfluenceViewModel();

        public LearnMore()
        {
            InitializeComponent();

            BarBackgroundColor = Color.FromHex("6A9BB1");
            BarTextColor = Color.Black;
            BackgroundColor = Color.FromHex("6A9BB1");
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await InfluenceViewModel.RefreshInfluences();
            BindingContext = InfluenceViewModel;
        }
    }
}
