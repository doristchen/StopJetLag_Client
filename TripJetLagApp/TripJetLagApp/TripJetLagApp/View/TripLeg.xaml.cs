using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TripJetLagApp.Model;

namespace TripJetLagApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TripLeg : ContentPage
    {
        public TripLeg()
        {
            InitializeComponent();
        }

        void On_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        void On_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var noteMobile = ((ListView)sender).SelectedItem as NoteMobile;
                var masterPage = this.Parent as TabbedPage;
               
                masterPage.Children[1].BindingContext = noteMobile;
                masterPage.CurrentPage = masterPage.Children[1];
                           
                if (noteMobile == null)
                    return;
            }
        }
    }

    
}
