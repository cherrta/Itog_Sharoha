using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая2
{
    class JsonClasses
    {
        public class Offer
        {
            public string type { get; set; }
            public string url { get; set; }
            public string status { get; set; }
        }


        public class Venue
        {
            //[DeserializeAs(Name = "venue")]
            public string country { get; set; }
            public string city { get; set; }
            public string latitude { get; set; }
            public string name { get; set; }
            public string location { get; set; }

            public string region { get; set; }
            public string longitude { get; set; }
        }

        public class Options
        {
            public bool display_listen_unit { get; set; }
        }

        public class Artist
        {
            public string thumb_url { get; set; }
            public string mbid { get; set; }

            public string facebook_page_url { get; set; }
            public string image_url { get; set; }
            public string name { get; set; }
            public Options options { get; set; }
            public string id { get; set; }
            public double tracker_count { get; set; }
            public double upcoming_event_count { get; set; }
            public string url { get; set; }
        }

        public class Root
        {

            public List<Offer> offers { get; set; }
            public Venue venue { get; set; }
            public DateTime datetime { get; set; }
            public Artist artist { get; set; }
            public DateTime on_sale_datetime { get; set; }
            public string description { get; set; }
            public List<string> lineup { get; set; }
            public string id { get; set; }
            public string title { get; set; }
            public string artist_id { get; set; }
            public string url { get; set; }
        }
    }
}
