using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using System.Globalization;
using static курсовая2.JsonClasses;
//using System.Device.Location;


namespace курсовая2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        PointLatLng point = new PointLatLng(39.73915, -104.9847);


        List<PointLatLng> points = new List<PointLatLng>();

        List<GMapObject> objs = new List<GMapObject>();
        List<ConcertData> data = new List<ConcertData>();


        

        public MainWindow()
        {
            InitializeComponent();
            ApiClient apiClient = new ApiClient();
            data = apiClient.LoadConcertData();
            apiClient.LoadConcertData();

  
        }


        private void MapLoaded(object sender, RoutedEventArgs e)
        {
            // настройка доступа к данным
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            // установка провайдера карт
            Map.MapProvider = GoogleMapProvider.Instance;
            // установка зума карты
            Map.MinZoom = 2;
            Map.MaxZoom = 17;
            Map.Zoom = 5;
            // установка фокуса карты
            Map.Position = new PointLatLng(39.73915, -104.9847);
            // настройка взаимодействия с картой
            Map.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            Map.CanDragMap = true;
            Map.DragButton = MouseButton.Left; 
        }

    

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
           foreach (ConcertData dt in data)
           {
               objs.Add(new AddMarker(dt.Country, dt.City, dt.Name, dt.Artist, dt.Time,
                   new PointLatLng(Convert.ToDouble(dt.x, CultureInfo.InvariantCulture),
                   Convert.ToDouble(dt.y, CultureInfo.InvariantCulture)), "good.png"));
           }

           foreach (GMapObject mk in objs)
           {
               Map.Markers.Add(mk.getMarker());
           }
        }
    }
}
