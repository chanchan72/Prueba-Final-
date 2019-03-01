﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WcfService1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string Contacto(string Nombre, string Email, long Telefono, string Asunto, string Mensaje)
        {
            dllPrincipal.Datos D = new dllPrincipal.Datos();
            string respuesta = "";
            respuesta = D.Contacto(Nombre, Email, Telefono, Asunto, Mensaje);
            return respuesta;
        }
    }
}
