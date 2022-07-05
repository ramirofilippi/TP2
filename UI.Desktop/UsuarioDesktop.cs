using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
            
        }
        public UsuarioDesktop(ModoForm modo):this()
        {
            this.Modo = modo;
        }
        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic usuario = new UsuarioLogic();
            UsuarioActual = usuario.GetOne(ID);
            this.MapearDeDatos();
        }
        private Usuario _UsuarioActual; 
        public Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
            set { _UsuarioActual = value; }
        }
        public new void MapearDeDatos() 
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtEmail.Text = this.UsuarioActual.EMail;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            switch (this.Modo)
            {
                case ApplicationForm.ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ApplicationForm.ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminiar";
                    break;
                case ApplicationForm.ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ApplicationForm.ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }
        public new void MapearADatos()
        {
            Usuario usuario = new Usuario();
            switch (this.Modo)
            {
                case ApplicationForm.ModoForm.Alta:
                    usuario.Nombre = this.txtNombre.Text;
                    usuario.Apellido = this.txtApellido.Text;
                    usuario.Clave = this.txtClave.Text;
                    usuario.EMail = this.txtEmail.Text;
                    usuario.Habilitado = this.chkHabilitado.Checked;
                    usuario.Nombre = this.txtNombre.Text;
                    usuario.NombreUsuario = this.txtUsuario.Text;
                    usuario.State = BusinessEntity.States.New;
                    UsuarioActual = usuario;
                    break;
                case ApplicationForm.ModoForm.Modificacion:
                    usuario.ID = int.Parse(this.txtID.Text);
                    usuario.Nombre = this.txtNombre.Text;
                    usuario.Apellido = this.txtApellido.Text;
                    usuario.Clave = this.txtClave.Text;
                    usuario.EMail = this.txtEmail.Text;
                    usuario.Habilitado = this.chkHabilitado.Checked;
                    usuario.Nombre = this.txtNombre.Text;
                    usuario.NombreUsuario = this.txtUsuario.Text;
                    usuario.State = BusinessEntity.States.Modified;
                    UsuarioActual = usuario;
                    break;
                case ApplicationForm.ModoForm.Baja:
                    usuario.ID = int.Parse(this.txtID.Text);
                    usuario.Nombre = this.txtNombre.Text;
                    usuario.Apellido = this.txtApellido.Text;
                    usuario.Clave = this.txtClave.Text;
                    usuario.EMail = this.txtEmail.Text;
                    usuario.Habilitado = this.chkHabilitado.Checked;
                    usuario.Nombre = this.txtNombre.Text;
                    usuario.NombreUsuario = this.txtUsuario.Text;
                    usuario.State = BusinessEntity.States.Deleted;
                    UsuarioActual = usuario;
                    break;
                case ApplicationForm.ModoForm.Consulta:
                    break;

            }
        }
        public new void GuardarCambios() 
        {
            MapearADatos();
            UsuarioLogic usuario = new UsuarioLogic();
            usuario.Save(UsuarioActual);
        }
        public new bool Validar() 
        {
            UsuarioLogic usuario = new UsuarioLogic();
            if (this.txtApellido.Text.Trim() == null || this.txtNombre.Text.Trim() == null || this.txtClave.Text.Trim() == null || this.txtConfirmarClave.Text.Trim() == null || usuario.VerificaMail(this.txtEmail.Text) == false || this.txtUsuario.Text.Trim() == null || this.txtClave.Text != this.txtConfirmarClave.Text || this.txtClave.Text.Length < 8)
            {
                Notificar("Error al ingresar algun dato","Falta algun dato o la confirmacion de la contraseña no coincide o la contraseña es muy corta o el mail no es valido", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            } 
        }
        public new void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public new void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
