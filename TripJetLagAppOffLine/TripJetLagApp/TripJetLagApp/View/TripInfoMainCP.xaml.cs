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
    public partial class TripInfoMainCP : CarouselPage
    {
        public TripInfoMainCP()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            NoteMobileViewModel NoteMobileViewModel =
                     new NoteMobileViewModel(3);
            AdviceMobileViewModel AdviceMobileViewModel =
                     new AdviceMobileViewModel(3);

            base.OnAppearing();

            await NoteMobileViewModel.RefreshTripNote();
            await AdviceMobileViewModel.RefreshTripAdvice();
            
            var advices = new AdviceCP();
            var triplegs = new TripLegCP();
            var triplegnotes = new TripLegNotesCP();

            advices.BindingContext = AdviceMobileViewModel;
            triplegs.BindingContext = NoteMobileViewModel;
            triplegnotes.BindingContext = NoteMobileViewModel;

            Children.Add(triplegs);
            Children.Add(triplegnotes);
            Children.Add(advices);


        }
    }
}
