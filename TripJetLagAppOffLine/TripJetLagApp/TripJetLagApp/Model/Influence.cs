namespace TripJetLagApp.Model
{
    public class Influence
    {
        public enum Categories
        {
            Watch = 1, Flight, Sleep, NoSleep, Light, NoLight, Meal, Activity, Caffeine, Supplement
        }

        public Categories CategoryId { get; set; }
        public string DisplayIcon { get; set; }
        public string BackgroundColor { get; set; }
        public string AdviceInfo { get; set; }
    }
}
