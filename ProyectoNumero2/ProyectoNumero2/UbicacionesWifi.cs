using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNumero2
{
	internal class UbicacionesWifi
	{

		private string municipio;
		private string puntoUbicacion;
		private string direccion;
		private string ubicacion;
		private string ubicacionDosColumnas;

		public UbicacionesWifi(string municipio, string puntoUbicacion, string direccion, string ubicacion, string ubicacionDosColumnas)
		{
			this.municipio = municipio;
			this.puntoUbicacion = puntoUbicacion;
			this.direccion = direccion;
			this.Ubicacion = ubicacion;
			this.UbicacionDosColumnas = ubicacionDosColumnas;
		}


		public override string ToString()
		{
			return municipio+" "+PuntoUbicacion+" "+direccion+" "+ubicacion+" "+ubicacionDosColumnas;
		}
		public string Municipio { get => municipio; set => municipio = value; }
		public string PuntoUbicacion { get => puntoUbicacion; set => puntoUbicacion = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public string Ubicacion { get => ubicacion; set => ubicacion = value; }
		public string UbicacionDosColumnas { get => ubicacionDosColumnas; set => ubicacionDosColumnas = value; }
	}
}
