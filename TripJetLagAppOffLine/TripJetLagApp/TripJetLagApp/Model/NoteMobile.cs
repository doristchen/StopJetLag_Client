using System;
using System.Collections.ObjectModel;
using SQLite;

namespace TripJetLagApp.Model
{
    public class NoteMobile
    {
        public int NoteId { get; set; }
        public string Note { get; set; }
        public int TripId { get; set; }
        public int TripLegId { get; set; }
        public int Segment { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }

        [Ignore]
        public string NoteTitle => DepartureAirport.ToString() +
                                              " to " + ArrivalAirport.ToString();
   }
}
