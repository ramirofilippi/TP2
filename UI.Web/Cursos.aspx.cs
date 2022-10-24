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
    public partial class Cursos : System.Web.UI.Page
    {
        CursoLogic _logic;
        private CursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new CursoLogic();
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
        private Curso Entity
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
            this.anioCalendarioTextBox.Text = this.Entity.AnioCalendario.ToString();
            this.cupoTextBox.Text = this.Entity.Cupo.ToString();
            this.descripcionTextBox.Text = this.Entity.Descripcion;
            this.idMateriaddl.Text = this.Entity.IDMateria.ToString();
            this.idComisionddl.Text = this.Entity.IDComision.ToString();
        }
        private void LoadEntity(Curso curso)
        {
            curso.AnioCalendario = int.Parse(this.anioCalendarioTextBox.Text);
            curso.Cupo = int.Parse(this.cupoTextBox.Text);
            curso.Descripcion = this.descripcionTextBox.Text;
            curso.IDMateria = int.Parse(this.idMateriaddl.Text);
            curso.IDComision = int.Parse(this.idComisionddl.Text);
        }
        private void SaveEntity(Curso curso)
        {
            this.Logic.Save(curso);
        }
        private void EnableForm(bool enable)
        {
            this.anioCalendarioTextBox.Enabled = enable;
            this.cupoTextBox.Enabled = enable;
            this.descripcionTextBox.Enabled = enable;
            this.idMateriaddl.Enabled = enable;
            this.idComisionddl.Enabled = enable;
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        private void ClearForm()
        {
            this.anioCalendarioTextBox.Text = string.Empty;
            this.cupoTextBox.Text = string.Empty;
            this.descripcionTextBox.Text = string.Empty;
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

            this.anioCalendarioLabelError.Visible = false;
            this.cupoLabelError.Visible = false;
            this.descripcionLabelError.Visible = false;
            this.idMateriaLabelError.Visible = false;
            this.idComisionLabelError.Visible = false;

            if (this.anioCalendarioTextBox.Text.Trim() == "")
            {
                val = false;
                this.anioCalendarioLabelError.Visible = true;
            }
            if (this.cupoTextBox.Text.Trim() == "")
            {
                val = false;
                this.cupoLabelError.Visible = true;
            }
            if (this.descripcionTextBox.Text.Trim() == "")
            {
                val = false;
                this.descripcionLabelError.Visible = true;
            }
            if (this.idMateriaddl.Text.Trim() == "")
            {
                val = false;
                this.idMateriaLabelError.Visible = true;
            }
            if (this.idComisionddl.Text.Trim() == "")
            {
                val = false;
                this.idComisionLabelError.Visible = true;
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
                        this.Entity = new Curso();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                    case FormModes.Alta:
                        this.Entity = new Curso();
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