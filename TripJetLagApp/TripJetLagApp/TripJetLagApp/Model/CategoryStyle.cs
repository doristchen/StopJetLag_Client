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
        public Categories CategoryId;
        public string DisplayIcon;
        public string BackgroundColor;

        public CategoryStyle(Categories CId, string Image, string Color)
        {
            CategoryId = CId;
            DisplayIcon = Image;
            BackgroundColor = Color;
        }
    }

    public class AdviceStyle
    {
        public static CategoryStyle[] Category =
          new CategoryStyle[]
             {
                new CategoryStyle (Categories.Watch, "watch.png", "#88FDA4"),
                new CategoryStyle (Categories.Flight, "flight.png","#96CAEE" ),
                new CategoryStyle (Categories.Sleep, "sleep.png","#EEEEEE" ),
                new CategoryStyle (Categories.NoSleep, "nosleep.png","#EEEEEE"),
                new CategoryStyle (Categories.Light, "light.png","#F7FF4A" ),
                new CategoryStyle (Categories.NoLight, "nolight.png","#D6D6CF" ),
                new CategoryStyle (Categories.Meal, "meal.png", "#EEEEEE"),
                new CategoryStyle (Categories.Activity, "activity.png","#EEEEEE" ),
                new CategoryStyle (Categories.Caffeine, "caffeine.png","#EEEEEE" ),
                new CategoryStyle (Categories.Supplement, "supplement.png","#EEEEEE")
              };


    }
}
