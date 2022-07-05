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
    public partial class PlanDesktop : ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
        }
        private Plan _PlanActual;
        public Plan PlanActual {
            get { return _PlanActual; }
            set { _PlanActual = value; }
        }
        public PlanDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            PlanLogic plan = new PlanLogic();
            PlanActual = plan.GetOne(ID);
            this.MapearDeDatos();
        }
        public new void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDescripcion.Text = this.PlanActual.Descripcion;
            this.txtIdEspecialidad.Text = this.PlanActual.IDEspecialidad.ToString();
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
            Plan plan = new Plan();
            switch (this.Modo)
            {
                case ApplicationForm.ModoForm.Alta:
                    plan.Descripcion = this.txtDescripcion.Text;
                    plan.IDEspecialidad = int.Parse(this.txtIdEspecialidad.Text);
                    plan.State = BusinessEntity.States.New;
                    PlanActual = plan;
                    break;
                case ApplicationForm.ModoForm.Modificacion:
                    plan.ID = int.Parse(this.txtID.Text);
                    plan.Descripcion = this.txtDescripcion.Text;
                    plan.IDEspecialidad = int.Parse(this.txtIdEspecialidad.Text);
                    plan.State = BusinessEntity.States.Modified;
                    PlanActual = plan;
                    break;
                case ApplicationForm.ModoForm.Baja:
                    plan.ID = int.Parse(this.txtID.Text);
                    plan.Descripcion = this.txtDescripcion.Text;
                    plan.IDEspecialidad = int.Parse(this.txtIdEspecialidad.Text);
                    plan.State = BusinessEntity.States.Deleted;
                    PlanActual = plan;
                    break;
                case ApplicationForm.ModoForm.Consulta:
                    break;

            }
        }
        public new bool Validar()
        {
            if (this.txtDescripcion.Text.Trim() == null || this.txtIdEspecialidad.Text.ToString().Trim() == null)
            {
                Notificar("Error al ingresar el dato", "La descripcion o el id de Especialidad ingrsada no pueden ser vacias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        public new void GuardarCambios()
        {
            MapearADatos();
            PlanLogic plan = new PlanLogic();
            plan.Save(PlanActual);
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
