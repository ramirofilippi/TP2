using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listadoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios formUsuarios = new Usuarios();
            formUsuarios.ShowDialog();
        }

        private void listadoEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades formEspecialidades = new Especialidades();
            formEspecialidades.ShowDialog();
        }

        private void listadoModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos formModulos = new Modulos();
            formModulos.ShowDialog();
        }

        private void listadoPlanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes formPlanes = new Planes();
            formPlanes.ShowDialog();
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Dispose(); // De esta forma compruebo que se incie sesion correctamente, sino, se cierra
            }
        }
    }
}
