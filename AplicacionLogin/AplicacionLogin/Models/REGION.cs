using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionLogin.Models
{
    public class REGION
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }

        public REGION(int id, string nombre, double lat, double lon)
        {
            this.id = id;
            this.nombre = nombre;
            this.lat = lat;
            this.lon = lon;
        }
    }
}