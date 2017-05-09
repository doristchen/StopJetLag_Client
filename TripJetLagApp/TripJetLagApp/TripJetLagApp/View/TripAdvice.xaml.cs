using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using TripJetLagApp.ViewModel;
using Xamarin.Forms;


namespace TripJetLagApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TripAdvice : ContentPage
    {

        AdviceMobileViewModel AdviceMobileViewModel =
            new AdviceMobileViewModel(3);

        public TripAdvice()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            
            base.OnAppearing();

            await AdviceMobileViewModel.RefreshTripAdvice();

            BindingContext = AdviceMobileViewModel;
         }
    }
}
