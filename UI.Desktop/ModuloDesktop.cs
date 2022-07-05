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
    public partial class ModuloDesktop : ApplicationForm
    {
        public ModuloDesktop()
        {
            InitializeComponent();
        }
        private Modulo _ModuloActual;
        public Modulo ModuloActual
        {
            get { return _ModuloActual; }
            set { _ModuloActual = value; }
        }
        public ModuloDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public ModuloDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            ModuloLogic modulo = new ModuloLogic();
            ModuloActual = modulo.GetOne(ID);
            this.MapearDeDatos();
        }
        public new void MapearDeDatos()
        {
            this.txtID.Text = this.ModuloActual.ID.ToString();
            this.txtDescripcion.Text = this.ModuloActual.Descripcion;
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
            Modulo modulo = new Modulo();
            switch (this.Modo)
            {
                case ApplicationForm.ModoForm.Alta:
                    modulo.Descripcion = this.txtDescripcion.Text;
                    modulo.State = BusinessEntity.States.New;
                    ModuloActual = modulo;
                    break;
                case ApplicationForm.ModoForm.Modificacion:
                    modulo.ID = int.Parse(this.txtID.Text);
                    modulo.Descripcion = this.txtDescripcion.Text;
                    modulo.State = BusinessEntity.States.Modified;
                    ModuloActual = modulo;
                    break;
                case ApplicationForm.ModoForm.Baja:
                    modulo.ID = int.Parse(this.txtID.Text);
                    modulo.Descripcion = this.txtDescripcion.Text;
                    modulo.State = BusinessEntity.States.Deleted;
                    ModuloActual = modulo;
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
            ModuloLogic modulo = new ModuloLogic();
            modulo.Save(ModuloActual);
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
