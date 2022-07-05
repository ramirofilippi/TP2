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
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
            this.dgvModulos.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            ModuloLogic modulo = new ModuloLogic();
            this.dgvModulos.DataSource = modulo.GetAll();
        }

        private void Modulos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ModuloDesktop formModulo = new ModuloDesktop(ApplicationForm.ModoForm.Alta);
            formModulo.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Modulo)this.dgvModulos.SelectedRows[0].DataBoundItem).ID;
            ModuloDesktop formModulo = new ModuloDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            if (this.dgvModulos.SelectedRows != null)
            {
                formModulo.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Debe selccionar una fila para poder realizar esta acción", "No se pudo elimiar el modulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Modulo)this.dgvModulos.SelectedRows[0].DataBoundItem).ID;
            ModuloDesktop formModulo = new ModuloDesktop(ID, ApplicationForm.ModoForm.Baja);
            if (this.dgvModulos.SelectedRows != null)
            {
                formModulo.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Debe selccionar una fila para poder realizar esta acción", "No se pudo editar el modulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
