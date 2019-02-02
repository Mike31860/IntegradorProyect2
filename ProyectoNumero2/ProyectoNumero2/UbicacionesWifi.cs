using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNumero2
{
	
	class UbicacionesWifi
	{

		private string municipio;
		private string puntoUbicacion;
		private string direccion;
		private int ubicacion;

		public UbicacionesWifi(string municipio, string puntoUbicacion, string direccion, int ubicacion)
		{
			this.Municipio = municipio;
			this.PuntoUbicacion = puntoUbicacion;
			this.Direccion = direccion;
			this.Ubicacion = ubicacion;
		}

		public string Municipio { get => municipio; set => municipio = value; }
		public string PuntoUbicacion { get => puntoUbicacion; set => puntoUbicacion = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public int Ubicacion { get => ubicacion; set => ubicacion = value; }
	}
}
