//using System;
//using System.Collections.Generic;
//using System.Text;
//using Newtonsoft.Json.Linq;

namespace DemoLibrary
{
//    class fraGit
//    {
//        public class Stash
//        {
//            public Stash(JObject rawData)
//            {
//                if (rawData["next_change_id"] != null)
//                    NextChangeId = rawData["next_change_id"].ToString();
//                if (rawData["stashes"] != null && rawData["stashes"].HasValues)
//                {
//                    Entries = new List<StashTab>();
//                    foreach (JObject obj in rawData["stashes"])
//                    {
//                        StashTab stash = new StashTab(obj);
//                        Entries.Add(stash);
//                    }
//                }
//            }

//            /// <summary>
//            ///     The Next Change ID for the API
//            /// </summary>
//            public string NextChangeId { get; internal set; }

//            /// <summary>
//            ///     The Retrieved Stashes
//            /// </summary>
//            public List<StashTab> Entries { get; internal set; }
//        }












//        private readonly string Api_Url;
//        private readonly string User_Agent;
//        public ExileAPI(string user_agent, string api_url)
//        {
//            User_Agent = user_agent;
//            Api_Url = api_url;
//        }

//        public async Task<Stash> GetPublicStashesAsync(string nextChangeId = null)
//        {
//            var request = new Request(User_Agent);
//            if (nextChangeId == null)
//                await request.Get($"{Api_Url}public-stash-tabs/");
//            else
//                await request.Get($"{Api_Url}public-stash-tabs/?id={nextChangeId}");

//            return new Stash(JObject.Parse(request.Response));
//        }
//    }
}
