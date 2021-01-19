using GMap.NET;
using GMap.NET.WindowsPresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace курсовая2
{
    class AddMarker : GMapObject
    {
        GMapMarker marker;
        PointLatLng location;

        public AddMarker(string country, string city, string name, string artist, string time, PointLatLng location, string img) : base(country, city, name, artist, time)
        {
            this.location = location;
            marker = new GMapMarker(location)
            {
                Shape = new Image
                {
                    Width = 35, // ширина маркера
                    Height = 35, // высота маркер
                    ToolTip = (country, city, name, artist, time),
                    Source = new BitmapImage(new Uri("pack://application:,,,/imgs/good.png")) // картинка
                }
            };
        }

        public override GMapMarker getMarker()
        {
            return marker;
        }
    }

}

