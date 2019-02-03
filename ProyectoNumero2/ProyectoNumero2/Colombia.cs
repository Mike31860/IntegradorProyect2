using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNumero2
{
	class Colombia
	{


		private List<UbicacionesWifi> ubicaciones;
		
		private Hashtable es;

		

		public Colombia()
		{
			Ubicaciones = new List<UbicacionesWifi>();
			es = new Hashtable();


		}

		

		public List<UbicacionesWifi> abrirArchivoCVS(String ruta)
		{
			

			String[] linea = File.ReadAllLines(ruta);

			for(int i=1; i<linea.Length; i++)
			{

				String[] linea2 = linea[i].Split(',');

				String municipio = linea2[0];
				String puntoUbicacion = linea2[1];
				String Direccion = linea2[2];
				String ubicacion = linea2[3];
				String ubicacionDos = linea2[4];
			
				UbicacionesWifi nueva = new UbicacionesWifi(municipio, puntoUbicacion, Direccion, ubicacion, ubicacionDos);
				es.Add(i-1,nueva);

				Ubicaciones.Add(nueva);






			}

			return ubicaciones;

		}


		internal List<UbicacionesWifi> Ubicaciones { get => ubicaciones; set => ubicaciones = value; }



	}










}
