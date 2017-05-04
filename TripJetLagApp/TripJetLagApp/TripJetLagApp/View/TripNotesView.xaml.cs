using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripJetLagApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripJetLagApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TripNotesView : TabbedPage
    {
         NoteMobileViewModel NoteMobileViewModel =
            new NoteMobileViewModel(3);

        public TripNotesView()
        {
            InitializeComponent();

            Children.Add(new TripLeg());
            Children.Add(new LegNote());
                        
            BarBackgroundColor = Color.FromHex("6A9BB1");
            BarTextColor = Color.Black;
            BackgroundColor = Color.FromHex("6A9BB1");

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await NoteMobileViewModel.RefreshTripNote();

            Children[0].BindingContext = NoteMobileViewModel;

            Children[1].BindingContext = NoteMobileViewModel.Notes[0];
        } 

    }
}
