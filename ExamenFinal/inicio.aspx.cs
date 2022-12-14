using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bingresar_Click(object sender, EventArgs e)
        {


            ClsUsuarios.Email = Tusuario.Text;
            ClsUsuarios.Clave = Tclave.Text;


            if (ClsUsuarios.ValidarLogin(ClsUsuarios.Email, ClsUsuarios.Clave) > 0)
            {
                
                    Response.Redirect("Main.aspx");
                
            }
            else
            {

            }

        }
    }
}
