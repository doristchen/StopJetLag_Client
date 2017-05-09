using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using TripJetLagApp.Model;

namespace TripJetLagApp.Data
{
    public class TripJetLagDataAccess
    {
       readonly SQLiteAsyncConnection database;

       public TripJetLagDataAccess(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Influence>().Wait();
            database.CreateTableAsync<AdviceMobile>().Wait();
            database.CreateTableAsync<NoteMobile>().Wait();
        }

        public Task<List<AdviceMobile>> GetAdvicesAsync()
        {
            return database.Table<AdviceMobile>().OrderBy(x => x.ArrivalDate).ToListAsync();
        }

        public Task<List<AdviceMobile>> GetAdvicesByTripIdAsync(int TripId)
        {
            return database.Table<AdviceMobile>()
                   .Where(s => s.TripId == TripId).OrderBy(x => x.ArrivalDate).ToListAsync();
        }

        public Task<int> SaveAdvicesAsync(List<AdviceMobile> items)
        {
            return database.InsertAllAsync(items);
        }

        public Task<int> SaveNotesAsync(List<NoteMobile> items)
        {
           return database.InsertAllAsync(items);
        }

        public Task<List<NoteMobile>> GetNotesAsync()
        {
            return database.Table<NoteMobile>().OrderBy(x => x.ArrivalDate).ToListAsync();
        }

        public Task<List<NoteMobile>> GetNotesByTripIdAsync(int TripId)
        {
            return database.Table<NoteMobile>().Where(s=>s.TripId == TripId)
                   .OrderBy(x => x.ArrivalDate).ToListAsync();
        }

        public Task<List<Influence>> GetInfluencesAsync()
        {
            return database.Table<Influence>().OrderBy(x => x.CategoryId).ToListAsync();
        }

        public Task<int> SaveInfluencesAsync(List<Influence> items)
        {
            return database.InsertAllAsync(items);
        }

        public Task<Influence> GetInfluenceByCategoryIdAsync(Influence.Categories CategoryId)
        {
            return database.Table<Influence>().Where(s => s.CategoryId == CategoryId).FirstOrDefaultAsync();
        }

    }
}

