using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TripJetLagApp.View;


namespace TripJetLagApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnbtnAdvice(object sender, EventArgs args)
        {
            Navigation.PushAsync(new TripAdvice());
        }


        void OnbtnNote(object sender, EventArgs args)
        {
            Navigation.PushAsync(new TripNotesView());
        }
    }

    
}
