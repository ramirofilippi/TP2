using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class ListaUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PaginaEnEstadoEdicion())
            {
                int id = int.Parse(Request.QueryString["ID"]);
                CargarDatosUsuario(id);
            }
        }

        protected void grdUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Verificarmos que se ejecute lo siguiente solamente cuando lo produce
            //a este evento el botón Insertar
            if (e.CommandName.ToLower() == "insertar")
            {
                TextBox cajaTexto;
                string textoActual;
                Usuario usuarioNuevo = new Usuario();

                //Busco el control y se lo asigno a la propiedad correspondiente 
                //del objeto Usuario
                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtNombre");
                textoActual = cajaTexto.Text;
                usuarioNuevo.Nombre = textoActual;

                //Así hago sucesivamente con el resto de los parámetros
                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtApellido");
                textoActual = cajaTexto.Text;
                usuarioNuevo.Apellido = textoActual;

                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtEmail");
                textoActual = cajaTexto.Text;
                usuarioNuevo.EMail = textoActual;

                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtNombreUsuario");
                textoActual = cajaTexto.Text;
                usuarioNuevo.NombreUsuario = textoActual;

                cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtClave");
                textoActual = cajaTexto.Text;
                usuarioNuevo.Clave = textoActual;

                //Defino una variable del Manager para ejecutar el evento de Insertar
                UsuarioLogic manager = new UsuarioLogic();

                //Agrego el Nuevo Usuario
                manager.Save(usuarioNuevo);

                //Actualizo la Grilla
                grdUsuarios.DataBind();
            }

        }
        private bool PaginaEnEstadoEdicion()
        {
            if (Request.QueryString["id"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CargarDatosUsuario(int idUsuario)
        {
            // 1 - Obtener los datos del usuario en cuestión
            // 2 - Cargar en los controles de la tabla los datos del usuario obtenido
        }

    }
}