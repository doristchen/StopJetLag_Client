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
    public class NoteMobileViewModel : BaseViewModel
    {
        TripJetLagRestService TripJetLagRestService { get; }
            = new TripJetLagRestService();

        int TripId;

        public ObservableCollection<NoteMobile> Notes { get; set; }
        public ObservableCollection<Grouping<string, NoteMobile>> NoteGrouped { get; set; }

        public NoteMobileViewModel(int id)
        {
            Notes = new ObservableCollection<NoteMobile>();
            TripId = id;
        }
        
        public async Task RefreshTripNote()
        {
            await GetRestTripNote(TripId);

            var sorted = from note in Notes
                         orderby note.ArrivalDate
                         group note by note.NoteTitle into noteGroup
                         select new Grouping<string, NoteMobile>(noteGroup.Key, noteGroup);
            NoteGrouped = new ObservableCollection<Grouping<string, NoteMobile>>(sorted);
        }

        public async Task GetRestTripNote(int id)
        {
            try
            {
                var Items = await TripJetLagRestService.GetTripNoteAsync(id);

                foreach (NoteMobile item in Items)
                {
                    Notes.Add(item);
                }

            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Cancel");
            }
        }
    }
}