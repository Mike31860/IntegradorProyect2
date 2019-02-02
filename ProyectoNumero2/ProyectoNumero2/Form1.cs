using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace ProyectoNumero2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void mapaColombia_Load(object sender, EventArgs e)
		{
			
			gmap.MapProvider = BingHybridMapProvider.Instance;
			GMaps.Instance.Mode = AccessMode.ServerOnly;
			gmap.SetPositionByKeywords("France, Paris");
			//gmap.Position = new GMap.NET.PointLatLng(5.8589507, -50.2775175);
			gmap.ShowCenter = false;


			

			GMapOverlay markers = new GMapOverlay("markers");
			GMapMarker marker = new GMarkerGoogle(new PointLatLng(48.8617774, 2.349272),GMarkerGoogleType.lightblue);
			markers.Markers.Add(marker);
			gmap.Overlays.Add(markers);






		}

		private void satelite_Click(object sender, EventArgs e)
		{
			gmap.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
		}

		private void normal_Click(object sender, EventArgs e)
		{
			gmap.MapProvider = GMapProviders.GoogleMap;

		}

		private void Relieve_Click(object sender, EventArgs e)
		{
			gmap.MapProvider = GMapProviders.GoogleTerrainMap;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			zoomMelo.Value = Convert.ToInt32(gmap.Zoom);
		}

		private void zoomMelo_ValueChanged(object sender, EventArgs e)
		{
			gmap.Zoom = zoomMelo.Value;
		}
	}
}
