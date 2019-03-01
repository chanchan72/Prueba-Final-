using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReferenciaWS.WebService1 ws = new ReferenciaWS.WebService1();

            Label6.Text = ws.Contacto(TextBox1.Text,TextBox2.Text,Convert.ToInt64(TextBox3.Text),TextBox4.Text,TextBox5.Text);

        }
    }
}