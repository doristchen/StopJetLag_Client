using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripJetLagApp.Service;
using TripJetLagApp.View;
using TripJetLagApp.ViewModel;
using TripJetLagApp.Model;
using Xamarin.Forms;

namespace TripJetLagApp
{

    public partial class App : Application
    {
        public App()
        {
             MainPage = new NavigationPage(new MainPage());
        }
        
        protected override void OnStart()
        {
            // Handle when your app starts

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
