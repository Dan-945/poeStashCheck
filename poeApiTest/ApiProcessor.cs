using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class ApiProcessor
    {
        public static async Task<StashesResult> LoadpoeInformation()
        {
            string url = "http://api.pathofexile.com/public-stash-tabs";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    StashesResult result = await response.Content.ReadAsAsync<StashesResult>();

                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
