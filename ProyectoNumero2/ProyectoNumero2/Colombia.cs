using System;
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

		public Colombia()
		{
			Ubicaciones = new List<UbicacionesWifi>();



		}

		internal List<UbicacionesWifi> Ubicaciones { get => ubicaciones; set => ubicaciones = value; }

		public List<UbicacionesWifi> abrirArchivoCVS(String ruta)
		{
			StreamReader leer = new StreamReader(ruta);
			leer.ReadLine();
			String mensaje = leer.ReadLine();
			

			while (mensaje != "")
			{

				String[] linea = mensaje.Split(',');

				String municipio = linea[0];
				String puntoUbicacion = linea[1];
				String Direccion = linea[2];
				int ubicacion = Int32.Parse(linea[3]);
				int ubicacionDos = Int32.Parse(linea[4]);
			
				UbicacionesWifi nueva = new UbicacionesWifi(municipio, puntoUbicacion, Direccion, ubicacion, ubicacionDos);
				Ubicaciones.Add(nueva);






			}

			return Ubicaciones;

		}






	}










}
