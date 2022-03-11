using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AreasWS
{
    /// <summary>
    /// Descripción breve de AreasWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreasWebService : System.Web.Services.WebService
    {

        

        [WebMethod]
        public string AreaCirculo(float R)
        {
            var resul = R * R * 3.14;
            return resul.ToString();
        }

        [WebMethod]
        public string AreaCuadrado(int L)
        {
            var resul = L * L;
            return resul.ToString();
        }

        [WebMethod]
        public string AreaTriangulo(float B, float A)
        {
            var resul = (B * A) / 2;
            return resul.ToString();
        }
       


    }
}
