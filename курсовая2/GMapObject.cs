using GMap.NET;
using GMap.NET.WindowsPresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая2
{
   public abstract class GMapObject 
    {
        public abstract GMapMarker getMarker();


        string name;
        string city;
        string country;
        string artist;
        string time;
        DateTime creationDate;

        public GMapObject(string country, string city, string name, string artist, string time)
        {
            this.time = time;
            this.name = name;
            this.city = city;
            this.country = country;
            this.artist = artist;
         
            creationDate = DateTime.Now;
        }

        

        public DateTime getCreationDate()
        {
            return creationDate;
        }
    }
}
