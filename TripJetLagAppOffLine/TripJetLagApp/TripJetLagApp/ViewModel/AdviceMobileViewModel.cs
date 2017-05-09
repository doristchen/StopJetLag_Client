using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MvvmHelpers;
using TripJetLagApp.Service;
using TripJetLagApp.Model;


namespace TripJetLagApp.ViewModel
{
    public class AdviceMobileViewModel : BaseViewModel
    {
        TripJetLagRestService TripJetLagRestService { get; }
            = new TripJetLagRestService();

        int TripId;
            
        public ObservableCollection<AdviceMobile> Advices { get; set; }
        public ObservableCollection<Grouping<string, AdviceMobile>> AdviceGrouped { get; set; }
     
        public AdviceMobileViewModel(int id)
        {
            Advices = new ObservableCollection<AdviceMobile>();
            TripId = id;
        }

        public async Task RefreshTripAdvice()
        {
            var Items = await App.Database.GetAdvicesByTripIdAsync(TripId);

            if (Items.Count == 0)
            {
                 await GetRestTripAdvice(TripId);
                 Items = await App.Database.GetAdvicesByTripIdAsync(TripId);
            }

            foreach (AdviceMobile item in Items)
            {
                Advices.Add(item);
            }

            var sorted = from advice in Advices
                         orderby advice.NotificationTime
                         group advice by advice.ArrivalSort into adviceGroup
                         select new Grouping<string, AdviceMobile>(adviceGroup.Key, adviceGroup);

            AdviceGrouped = new ObservableCollection<Grouping<string, AdviceMobile>>(sorted); 
        }

        public async Task GetRestTripAdvice(int id)
        {
            try
            {
               var Items = await TripJetLagRestService.GetTripAdviceAsync(id);
               await App.Database.SaveAdvicesAsync(Items);
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Cancel");
            }
        }
    }
}
