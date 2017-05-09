using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripJetLagApp.Model
{
    public enum Categories
    {
        Watch=1,Flight,Sleep,NoSleep,Light,NoLight,Meal,Activity,Caffeine,Supplement
    }

    public class CategoryStyle
    {
        public Categories CategoryId { get; set; }
        public string DisplayIcon { get; set; }
        public string BackgroundColor { get; set; }
    }

    public class AdviceStyle
    {
        public static CategoryStyle[] Category =
          new CategoryStyle[]
             {
                new CategoryStyle {
                    CategoryId = Categories.Watch,
                    DisplayIcon = "watch.png",
                    BackgroundColor = "#88FDA4" },
                new CategoryStyle {
                    CategoryId = Categories.Flight,
                    DisplayIcon = "flight.png",
                    BackgroundColor = "#96CAEE" },
                new CategoryStyle {CategoryId = Categories.Sleep,
                    DisplayIcon = "sleep.png",
                    BackgroundColor = "#EEEEEE" },
                new CategoryStyle {CategoryId = Categories.NoSleep,
                    DisplayIcon = "nosleep.png",
                    BackgroundColor = "#EEEEEE" },
                new CategoryStyle {CategoryId = Categories.Light,
                    DisplayIcon = "light.png",
                    BackgroundColor = "#F7FF4A" },
                new CategoryStyle {CategoryId = Categories.NoLight,
                    DisplayIcon = "nolight.png",
                    BackgroundColor = "#D6D6CF" },
                new CategoryStyle {CategoryId = Categories.Meal,
                    DisplayIcon = "meal.png",
                    BackgroundColor = "#EEEEEE" },
                new CategoryStyle {CategoryId = Categories.Activity,
                    DisplayIcon = "activity.png",
                    BackgroundColor = "#EEEEEE" },
                new CategoryStyle {CategoryId = Categories.Caffeine,
                    DisplayIcon = "caffeine.png",
                    BackgroundColor = "#EEEEEE" },
                new CategoryStyle {CategoryId = Categories.Supplement,
                    DisplayIcon = "supplement.png",
                    BackgroundColor = "#EEEEEE" }
              };
    }
}
