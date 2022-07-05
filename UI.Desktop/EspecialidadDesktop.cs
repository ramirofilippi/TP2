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
    public partial class EspecialidadDesktop : ApplicationForm
    {
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }
        private Especialidad _EspecialidadActual;
        public Especialidad EspecialidadActual
        {
            get { return _EspecialidadActual; }
            set { _EspecialidadActual = value; }
        }
        public EspecialidadDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            EspecialidadLogic especialidad = new EspecialidadLogic();
            EspecialidadActual = especialidad.GetOne(ID);
            this.MapearDeDatos();
        }
        public new void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;
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
            Especialidad especialidad = new Especialidad();
            switch (this.Modo)
            {
                case ApplicationForm.ModoForm.Alta:
                    especialidad.Descripcion = this.txtDescripcion.Text;
                    especialidad.State = BusinessEntity.States.New;
                    EspecialidadActual = especialidad;
                    break;
                case ApplicationForm.ModoForm.Modificacion:
                    especialidad.ID = int.Parse(this.txtID.Text);
                    especialidad.Descripcion = this.txtDescripcion.Text;
                    especialidad.State = BusinessEntity.States.Modified;
                    EspecialidadActual = especialidad;
                    break;
                case ApplicationForm.ModoForm.Baja:
                    especialidad.ID = int.Parse(this.txtID.Text);
                    especialidad.Descripcion = this.txtDescripcion.Text;
                    especialidad.State = BusinessEntity.States.Deleted;
                    EspecialidadActual = especialidad;
                    break;
                case ApplicationForm.ModoForm.Consulta:
                    break;

            }
        }
        public new bool Validar()
        {
            if (this.txtDescripcion.Text.Trim() == null)
            {
                Notificar("Error al ingresar el dato", "La descripcion ingrsada no puede ser vacia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            EspecialidadLogic especialidad = new EspecialidadLogic();
            especialidad.Save(EspecialidadActual);
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
