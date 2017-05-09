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
    public class InfluenceViewModel:BaseViewModel
    {
        public ObservableCollection<Influence> Influences { get; set; }

        public InfluenceViewModel()
        {
            Influences = new ObservableCollection<Influence>();
        }

        public async Task RefreshInfluences()
        {
            var Items = await App.Database.GetInfluencesAsync();

            foreach (Influence item in Items)
            {
                Influences.Add(item);
            }
        }

        public static async Task InitializeInfluences()
        {
            var Items = await App.Database.GetInfluencesAsync();

            if (Items.Count > 0)
                return;

            Items = new List <Influence>
            {
                new Influence {
                    CategoryId = Influence.Categories.Watch,
                    DisplayIcon = "watch.png",
                    BackgroundColor = "#88FDA4",
                    AdviceInfo = "The Optimal Time to Start Functioning on Your Destination Time" },
                new Influence{
                    CategoryId = Influence.Categories.Flight,
                    DisplayIcon = "flight.png",
                    BackgroundColor = "#96CAEE",
                    AdviceInfo = "based on your specific flights" },
                new Influence{
                    CategoryId = Influence.Categories.Sleep,
                    DisplayIcon = "sleep.png",
                    BackgroundColor = "#EEEEEE",
                    AdviceInfo = "and you sleep patterns," },
                new Influence{
                    CategoryId = Influence.Categories.NoSleep,
                    DisplayIcon = "nosleep.png",
                    BackgroundColor = "#EEEEEE",
                    AdviceInfo = "when to keep active and NOT nap," },
                new Influence{
                    CategoryId = Influence.Categories.Light,
                    DisplayIcon = "light.png",
                    BackgroundColor = "#F7FF4A",
                    AdviceInfo = "light exposure," },
                new Influence{
                    CategoryId = Influence.Categories.NoLight,
                    DisplayIcon = "nolight.png",
                    BackgroundColor = "#D6D6CF",
                    AdviceInfo = "avoid light exposure," },
                 new Influence{
                    CategoryId = Influence.Categories.Meal,
                    DisplayIcon = "meal.png",
                    BackgroundColor = "#EEEEEE",
                    AdviceInfo = "meal times, types and sizes," },
                 new Influence{
                    CategoryId = Influence.Categories.Activity,
                    DisplayIcon = "activity.png",
                    BackgroundColor = "#EEEEEE",
                    AdviceInfo = "activity and light exercise," },
                 new Influence{
                    CategoryId = Influence.Categories.Caffeine,
                    DisplayIcon = "caffeine.png",
                    BackgroundColor = "#EEEEEE",
                    AdviceInfo = "times for caffeine intake," },
                  new Influence{
                    CategoryId = Influence.Categories.Supplement,
                    DisplayIcon = "supplement.png",
                    BackgroundColor = "#EEEEEE",
                    AdviceInfo = "melatonin supplements" }
            };
            await App.Database.SaveInfluencesAsync(Items);
        }
    }
}
