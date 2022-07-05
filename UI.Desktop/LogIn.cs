using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogic usuario = new UsuarioLogic();
            List<Usuario> usr = usuario.GetAll();
            bool encontrado = false;

            foreach(Usuario u in usr)
            {
                if(u.Clave == this.txtClave.Text && u.NombreUsuario == this.txtUsuario.Text)
                {
                    Menu menu = new Menu();
                    MessageBox.Show("El usuario y la contraseña son correctos", "Ha ingresado correctamente", MessageBoxButtons.OK); 
                    this.Close();
                    encontrado = true;
                    this.DialogResult = DialogResult.OK;
                    break;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("El usuario o la contraseña es incorrecta", "Ha ingresado un dato erroneamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
