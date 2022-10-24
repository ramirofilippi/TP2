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
    public partial class Materias : System.Web.UI.Page
    {
        MateriaLogic _logic;
        private MateriaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new MateriaLogic();
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
        private Materia Entity
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
            this.descripcionTextBox.Text = this.Entity.Descripcion;
            //this.idEspecialidadDropDownList = this.Entity.IDEspecialidad;

        }
        private void LoadEntity(Materia materia)
        {
            materia.Descripcion = this.descripcionTextBox.Text;
            materia.HSSemanales = int.Parse(this.hsSemanalesTextBox.Text);
            materia.HSTotales = int.Parse(this.hsTotalesTextBox.Text);
            materia.IDPlan = int.Parse(this.idPlanDropDownList.Text);
        }
        private void SaveEntity(Materia materia)
        {
            this.Logic.Save(materia);
        }
        private void EnableForm(bool enable)
        {
            this.descripcionTextBox.Enabled = enable;
            this.hsTotalesTextBox.Enabled = enable;
            this.hsSemanalesTextBox.Enabled = enable;
            this.idPlanDropDownList.Enabled = enable;
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        private void ClearForm()
        {
            this.descripcionTextBox.Text = string.Empty;
            this.hsSemanalesTextBox.Text = string.Empty;
            this.hsTotalesTextBox.Text = string.Empty;
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

            this.descripcionLabelError.Visible = false;
            this.idPlanLabelError.Visible = false;
            this.hsTotalesLabelError.Visible = false;
            this.hsSemanalesLabelError.Visible = false;

            if (this.descripcionTextBox.Text.Trim() == "")
            {
                val = false;
                this.descripcionLabelError.Visible = true;
            }
            if (this.hsTotalesTextBox.Text.Trim() == "")
            {
                val = false;
                this.hsTotalesLabelError.Visible = true;
            }
            if (this.hsSemanalesTextBox.Text.Trim() == "")
            {
                val = false;
                this.hsSemanalesLabelError.Visible = true;
            }
            if (this.idPlanDropDownList.Text.Trim() == "")
            {
                val = false;
                this.idPlanLabelError.Visible = true;
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
                        this.Entity = new Materia();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                    case FormModes.Alta:
                        this.Entity = new Materia();
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