using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static курсовая2.JsonClasses;

namespace курсовая2
{
    class JsonParser
    {
        public List<ConcertData> ParseConcertData(string data)
        {

            List<Root> myDeserializedClass = JsonConvert.DeserializeObject <List<Root>>(data);
            return /*new List<ConcertData>();*/ convert(myDeserializedClass);
        }

        private List<ConcertData> convert(List<Root> root)
        {
            List<ConcertData> convertedData = new List<ConcertData>();
            foreach (Root r in root)
            {
                var concert = new ConcertData()
                {
                    Time="Время:"+r.datetime,
                    Artist = "Артист:" + r.lineup[0],
                    Country = "Страна:" + r.venue.country,
                    City ="Город:" + r.venue.city,
                    Name = "Место:" + r.venue.name,
                    Location = r.venue.location,
                    x = r.venue.latitude,
                    y = r.venue.longitude,
                };
                convertedData.Add(concert);
            }
            return convertedData;
        }


    }
}
