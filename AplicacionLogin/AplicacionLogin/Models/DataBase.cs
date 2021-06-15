using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionLogin.Models
{
    public class DataBase
    {
        public List<REGION> Regiones { get; set; }

        public DataBase()
        {
            Regiones = new List<REGION>();
            Regiones.Add(new REGION(15, "REGIÓN DE ARICA Y PARINACOTA", -69.6285400390625, -18.4969329833984));
            Regiones.Add(new REGION(1, "REGIÓN DE TARAPACÁ", -69.39306640625, -20.2157936096191));
            Regiones.Add(new REGION(2, "REGIÓN DE ANTOFAGASTA", -69.19140625, -23.5359897613525));
            Regiones.Add(new REGION(3, "REGIÓN DE ATACAMA", -69.9101409912109, -27.3952846527099));
            Regiones.Add(new REGION(4, "REGIÓN DE COQUIMBO", -70.8606948852539, -30.6190338134765));
            Regiones.Add(new REGION(5, "REGIÓN DE VALPARAÍSO", -71.3873596191406, -32.7320098876953));
            Regiones.Add(new REGION(13, "REGIÓN METROPOLITANA DE SANTIAGO", -70.6270599365234, -33.6043434143066));
            Regiones.Add(new REGION(6, "REGIÓN DEL LIBERTADOR GENERAL BERNARDO O'HIGGINS", -71.0465621948242, -34.4353637695312));
            Regiones.Add(new REGION(7, "REGIÓN DEL MAULE", -71.4456481933593, -35.6213302612304));
            Regiones.Add(new REGION(16, "REGIÓN DEL ÑUBLE", -71.9746398925781, -36.6454124450683));
            Regiones.Add(new REGION(8, "REGIÓN DEL BIOBÍO", -72.3924179077148, -37.500560760498));
            Regiones.Add(new REGION(9, "REGIÓN DE LA ARAUCANÍA", -72.2742462158203, -38.6491546630859));
            Regiones.Add(new REGION(14, "REGIÓN DE LOS RÍOS", -72.5708618164062, -40.0049819946289));
            Regiones.Add(new REGION(10, "REGIÓN DE LOS LAGOS", -72.8941802978515, -42.0428085327148));
            Regiones.Add(new REGION(11, "REGIÓN DE AYSÉN DEL GENERAL CARLOS IBÁÑEZ DEL CAMPO", -73.257080078125, -46.4165229797363));
            Regiones.Add(new REGION(12, "REGIÓN DE MAGALLANES Y DE LA ANTÁRTICA CHILENA", -71.8736038208007, -52.4883193969726));


        }
    }
}