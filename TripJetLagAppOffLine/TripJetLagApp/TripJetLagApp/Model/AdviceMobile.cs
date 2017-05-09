using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SQLite;

namespace TripJetLagApp.Model
{
    public class AdviceMobile
    {
        public int AdviceId { get; set; }
        public int CategoryId { get; set; }
        public string AdviceText { get; set; }
        public DateTime NotificationTime { get; set; }
        public string ImageIcon { get; set; }
        public int TripId { get; set; }
        public int TripLegId { get; set; }
        public int Segment { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }

        public string Notification
        {
            get
            {
                return
                     NotificationTime.ToString(@"MM/dd hh:mm tt", new CultureInfo("en-US"));
              }
        }

        [Ignore]
        public string ArrivalSort => ArrivalAirport.ToString();

        public string DisplayIcon
        {
            get
            {
                Influence.Categories Cid = (Influence.Categories)CategoryId;
                return App.Database.GetInfluenceByCategoryIdAsync((Influence.Categories)CategoryId).Result.DisplayIcon;
            }
        }

        public string BKGColor
        {
            get
            {
                Influence.Categories Cid = (Influence.Categories)CategoryId;
                return App.Database.GetInfluenceByCategoryIdAsync((Influence.Categories)CategoryId).Result.BackgroundColor;
             }
        }
    }
}
