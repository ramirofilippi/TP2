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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            UsuarioLogic usuario = new UsuarioLogic();
            try
            {
                this.dgvUsuarios.DataSource = usuario.GetAll();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                //MessageBox.Show("Ha habido un error en la carga del listado", "No se pudo cargar el listado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop formUsuario = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            formUsuario.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            UsuarioDesktop formUsuario = new UsuarioDesktop(ID,ApplicationForm.ModoForm.Baja);
            if (this.dgvUsuarios.SelectedRows != null)
            {
                formUsuario.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Debe selccionar una fila para poder realizar esta acción", "No se pudo elimiar al usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            UsuarioDesktop formUsuario = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            if (this.dgvUsuarios.SelectedRows != null)
            {
                formUsuario.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Debe selccionar una fila para poder realizar esta acción", "No se pudo editar al usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
