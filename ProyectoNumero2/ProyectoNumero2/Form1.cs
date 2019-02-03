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
using System.Collections;

namespace ProyectoNumero2
{
    public partial class Form1 : Form
    {


		private Colombia mundo;


        public Form1()
        {
			mundo = new Colombia();
            InitializeComponent();
        }

		private void mapaColombia_Load(object sender, EventArgs e)
		{
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(3.4372201, -76.5224991);
       

            






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

		private void ABRIROPEN_Click(object sender, EventArgs e)
		{
			abrirDialogo.InitialDirectory = ".//DataBase";
			if (abrirDialogo.ShowDialog() == DialogResult.OK)
			{
				
				Hashtable lista = mundo.abrirArchivoCVS(abrirDialogo.FileName);
				

				for (int i = 1; i < lista.Count+1; i++)
				{

					String[] linea = lista[i].ToString().Split('_');
					dataGridView1.Rows.Add(linea[0], linea[1]
						, linea[2], linea[3], linea[4]);


					String este= linea[3];
					string strModified = este.Substring(1, este.Length-1);
					String otro = linea[4];
					string strModified2 = otro.Substring(0, otro.Length - 2);

					double primero = Convert.ToDouble(strModified);
					double segundo= Convert.ToDouble(strModified2);
					GMapOverlay markers = new GMapOverlay("markers");
					GMapMarker marker = new GMarkerGoogle(new PointLatLng(primero, segundo), GMarkerGoogleType.lightblue);
					markers.Markers.Add(marker);
					marker.ToolTipText = ""+ linea[0]+"\n"+ linea[1]+
						"\n"+ linea[2]+ "\n" + linea[3]+ "\n" + linea[4];
					gmap.Overlays.Add(markers);
				}



			}

		}
	}
}
