using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripJetLagApp.Data;
using Xamarin.Forms;

namespace TripJetLagApp
{
    public partial class App : Application
    {
        static TripJetLagDataAccess database;

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

        public static TripJetLagDataAccess Database
        {
            get
            {
                if (database == null)
                {
                    database = new TripJetLagDataAccess(DependencyService.Get<IFileHelper>().GetLocalFilePath("TripJetLagSQLite.db3"));
                }
                return database;
            }
        }
    }
}
