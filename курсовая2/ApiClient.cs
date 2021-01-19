using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая2
{
    class ApiClient
    {

        
        const string URL = "https://rest.bandsintown.com/artists/Maroon5/events?app_id=3c92fcde629b9824e4f0be082644f5b2";
        

        RestClient client=null;
        JsonParser jsonParser = new JsonParser();

        public ApiClient()
        {
            client = new RestClient(URL);
            client.Timeout = -1;
        }

        public List<ConcertData> LoadConcertData()
        {
            string uri = string.Format(URL);
            var request = new RestRequest(uri, Method.GET);
            var response = client.Execute(request);
            string data = response.Content;
            return jsonParser.ParseConcertData(data);
        }
    }
}
