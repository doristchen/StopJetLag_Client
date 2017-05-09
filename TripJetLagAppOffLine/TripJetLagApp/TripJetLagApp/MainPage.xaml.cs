using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TripJetLagApp.View;
using TripJetLagApp.ViewModel;

namespace TripJetLagApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await InfluenceViewModel.InitializeInfluences();
        }
        void OnbtnAdvice(object sender, EventArgs args)
        {
            Navigation.PushAsync(new TripAdvice());
        }

        void OnbtnNote(object sender, EventArgs args)
        {
            Navigation.PushAsync(new TripNotesView());
        }

        void OnbtnLearnMore(object sender, EventArgs args)
        {
            Navigation.PushAsync(new LearnMore());
        }

        void OnbtnTripInfo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new TripInfoMainCP());
        }
    }

    
}
