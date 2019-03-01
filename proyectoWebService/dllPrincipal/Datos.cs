using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dllPrincipal
{
    public class Datos
    {
        private dbDatosDataContext dContext = new dbDatosDataContext();

        public string Contacto(string Nombre,string Email,long Telefono,string Asunto,string Mensaje)
        {
            try
            {
                Contacto Cont = new Contacto();
                Cont.Nombre = Nombre;
                Cont.Email = Email;
                Cont.Telefono = Telefono;
                Cont.Asunto = Asunto;
                Cont.Mensaje = Mensaje;
                dContext.Contactos.InsertOnSubmit(Cont);
                dContext.SubmitChanges();
                return "Inserto";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
