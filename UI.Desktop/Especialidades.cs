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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
            this.dgvEspecialidades.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            EspecialidadLogic especialidad = new EspecialidadLogic();
            this.dgvEspecialidades.DataSource = especialidad.GetAll();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            int ID = ((Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            if (this.dgvEspecialidades.SelectedRows != null)
            {
                formEspecialidad.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Debe selccionar una fila para poder realizar esta acción", "No se pudo editar la especialidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click_1(object sender, EventArgs e)
        {
            int ID = ((Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop formEspecialidades = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Baja);
            if (this.dgvEspecialidades.SelectedRows != null)
            {
                formEspecialidades.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("Debe selccionar una fila para poder realizar esta acción", "No se pudo eliminar la especialidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
