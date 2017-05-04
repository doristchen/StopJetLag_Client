using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TripJetLagApp.Model;

namespace TripJetLagApp.Service
{
    public class TripJetLagRestService
    {
        const string TripLegAdviceUri =
            "http://tripjetlagapi.azurewebsites.net/api/triplegs/{0}/advices";

        const string TripAdviceUri =
            "http://tripjetlagapi.azurewebsites.net/api/trips/{0}/advices";

        const string TripLegNoteUri =
            "http://tripjetlagapi.azurewebsites.net/api/triplegs/{0}/notes";

        const string TripNoteUri =
            "http://tripjetlagapi.azurewebsites.net/api/trips/{0}/notes";

        public async Task<List<AdviceMobile>> GetTripLegAdviceAsync(int id)
        {
            var uri = string.Format(TripLegAdviceUri, id.ToString());

            using (var client = new HttpClient())
            {
                var url = string.Format(TripLegAdviceUri, id.ToString());
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                return JsonConvert.DeserializeObject<List<AdviceMobile>>(json);
            }
        }

        public async Task<List<AdviceMobile>> GetTripAdviceAsync(int id)
        {
            var uri = string.Format(TripAdviceUri, id.ToString());

            using (var client = new HttpClient())
            {
                var url = string.Format(TripAdviceUri, id.ToString());
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                return JsonConvert.DeserializeObject<List<AdviceMobile>>(json);
            }
        }

        public async Task<NoteMobile> GetTripLegNoteAsync(int id)
        {
            var uri = string.Format(TripLegNoteUri, id.ToString());

            using (var client = new HttpClient())
            {
                var url = string.Format(TripLegNoteUri, id.ToString());
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                return JsonConvert.DeserializeObject<NoteMobile>(json);
            }
        }

        public async Task<List<NoteMobile>> GetTripNoteAsync(int id)
        {
            var uri = string.Format(TripNoteUri, id.ToString());

            using (var client = new HttpClient())
            {
                var url = string.Format(TripNoteUri, id.ToString());
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                return JsonConvert.DeserializeObject<List<NoteMobile>>(json);
            }
        }
    }
}
