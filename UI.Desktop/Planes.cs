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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            this.dgvPlanes.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            PlanLogic plan = new PlanLogic();
            this.dgvPlanes.DataSource = plan.GetAll();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop formPlan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            formPlan.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop formPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            if (this.dgvPlanes.SelectedRows != null)
            {
                formPlan.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Debe selccionar una fila para poder realizar esta acción", "No se pudo editar el plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop formPlanes = new PlanDesktop(ID, ApplicationForm.ModoForm.Baja);
            if (this.dgvPlanes.SelectedRows != null)
            {
                formPlanes.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Debe selccionar una fila para poder realizar esta acción", "No se pudo eliminar el plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
