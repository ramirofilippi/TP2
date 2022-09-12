using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //Valido nombre y contraseña
            /*if (txtUsuario.Text.ToLower() == "admin" && this.txtClave.Text == "admin")
            {
                Page.Response.Write("Ingreso OK");
            }
            else
            {
                Page.Response.Write("Usuario y/o Contraseña incorrectos");
            }*/
            UsuarioLogic usuario = new UsuarioLogic();
            List<Usuario> usr = usuario.GetAll();
            bool encontrado = false;

            foreach (Usuario u in usr)
            {
                if (u.Clave == this.txtClave.Text && u.NombreUsuario == this.txtUsuario.Text)
                {
                    Response.Redirect("~/Default.aspx?");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Page.Response.Write("<script>alert('El usuario y/o la contraseña son incorrectos');</script>");
            }
        }

        protected void lnkRecordarClave_Click(object sender, EventArgs e)
        {
            //Redirecciono a otra pagina que deberia existir y para mostrar el mensaje tener dicho elemento
            Page.Response.Write("<script>alert('Es Ud. un usuario muy descuidado, haga memoria');</script>");
        }
    }
}