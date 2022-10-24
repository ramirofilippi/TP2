using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Personas : System.Web.UI.Page
    {
        PersonasLogic _logic;
        private PersonasLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new PersonasLogic();
                }
                return _logic;
            }
        }
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }
        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }
        private Business.Entities.Personas Entity
        {
            get;
            set;
        }
        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }
        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.direccionTextBox.Text = this.Entity.Direccion;
            this.emailTextBox.Text = this.Entity.Email;
            this.fechaNacimientoCalendar.SelectedDate = this.Entity.FechaNacimiento;
            this.idPLanTextBox.Text = this.Entity.IDPlan.ToString();
            this.legajoTextBox.Text = this.Entity.Legajo.ToString();
            this.telefonoTextBox.Text = this.Entity.Telefono;
        }
        private void LoadEntity(Business.Entities.Personas per)
        {
            per.Nombre = this.nombreTextBox.Text;
            per.Apellido = this.apellidoTextBox.Text;
            per.Email = this.emailTextBox.Text;
            per.Direccion = this.direccionTextBox.Text;
            per.FechaNacimiento = this.fechaNacimientoCalendar.SelectedDate;
            per.IDPlan = int.Parse(this.idPLanTextBox.Text);
            per.Legajo = int.Parse(this.legajoTextBox.Text);
            per.Telefono= this.telefonoTextBox.Text;
        }
        private void SaveEntity(Business.Entities.Personas per)
        {
            this.Logic.Save(per);
        }
        private void EnableForm(bool enable)
        {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.direccionTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.idPLanTextBox.Enabled = enable;
            this.legajoTextBox.Enabled = enable;
            this.telefonoTextBox.Visible = enable;
            this.fechaNacimientoCalendar.Visible = enable;
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        private void ClearForm()
        {
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.direccionTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.idPLanTextBox.Text = string.Empty;
            this.legajoTextBox.Text = string.Empty;
            this.telefonoTextBox.Text = string.Empty;
        }
        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                this.EnableForm(true);
            }
        }
        private bool Validar()
        {
            bool val = true;

            this.nombreLabelError.Visible = false;
            this.apellidoLabelError.Visible = false;
            this.emailLabelError.Visible = false;
            this.direccionLabelError.Visible = false;
            this.idPLanLabelError.Visible = false;
            this.legajoLabelError.Visible = false;
            this.telefonoLabelError.Visible = false;
            this.fechaNacimientoLabelError.Visible = false;

            if (this.apellidoTextBox.Text.Trim() == "")
            {
                val = false;
                this.apellidoLabelError.Visible = true;
            }
            if (this.nombreTextBox.Text.Trim() == "")
            {
                val = false;
                this.nombreLabelError.Visible = true;
            }
            if (this.direccionTextBox.Text.Trim() == "")
            {
                val = false;
                this.nombreLabelError.Visible = true;
            }
            if (this.legajoTextBox.Text.Trim() == "")
            {
                val = false;
                this.legajoLabelError.Visible = true;
            }
            if (this.telefonoTextBox.Text.Trim() == "")
            {
                val = false;
                this.telefonoLabelError.Visible = true;
            }
            if (this.idPLanTextBox.Text.Trim() == "")
            {
                val = false;
                this.idPLanLabelError.Visible = true;
            }
            if(this.fechaNacimientoCalendar.SelectedDate == null)
            {
                val = false;
                this.fechaNacimientoLabel.Visible = true;
            }

            return val;
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.FormMode == FormModes.Baja)
            {
                this.DeleteEntity(this.SelectedID);
                this.LoadGrid();
                this.formPanel.Visible = false;
            }
            if (Validar())
            {
                switch (this.FormMode)
                {
                    case FormModes.Modificacion:
                        this.Entity = new Business.Entities.Personas();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = BusinessEntity.States.Modified;
                        this.Entity.TipoPersona = Business.Entities.Personas.TiposPersonas.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                    case FormModes.Alta:
                        this.Entity = new Business.Entities.Personas();
                        this.Entity.TipoPersona = Business.Entities.Personas.TiposPersonas.New;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                    default:
                        break;
                }

                this.formPanel.Visible = false;
            }
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
            this.ClearForm();
            this.EnableForm(false);
        }
    }
}