
namespace UI.Desktop
{
    partial class PlanDesktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlEspecialidadDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lID = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lIdEspecialidad = new System.Windows.Forms.Label();
            this.cmbIdEspecialidad = new System.Windows.Forms.ComboBox();
            this.tlEspecialidadDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlEspecialidadDesktop
            // 
            this.tlEspecialidadDesktop.ColumnCount = 4;
            this.tlEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.06773F));
            this.tlEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.93227F));
            this.tlEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tlEspecialidadDesktop.Controls.Add(this.lID, 0, 0);
            this.tlEspecialidadDesktop.Controls.Add(this.lDescripcion, 2, 0);
            this.tlEspecialidadDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlEspecialidadDesktop.Controls.Add(this.txtDescripcion, 3, 0);
            this.tlEspecialidadDesktop.Controls.Add(this.btnAceptar, 2, 2);
            this.tlEspecialidadDesktop.Controls.Add(this.btnCancelar, 3, 2);
            this.tlEspecialidadDesktop.Controls.Add(this.lIdEspecialidad, 0, 1);
            this.tlEspecialidadDesktop.Controls.Add(this.cmbIdEspecialidad, 1, 1);
            this.tlEspecialidadDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlEspecialidadDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlEspecialidadDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlEspecialidadDesktop.Name = "tlEspecialidadDesktop";
            this.tlEspecialidadDesktop.RowCount = 3;
            this.tlEspecialidadDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tlEspecialidadDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tlEspecialidadDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlEspecialidadDesktop.Size = new System.Drawing.Size(704, 155);
            this.tlEspecialidadDesktop.TabIndex = 2;
            // 
            // lID
            // 
            this.lID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(3, 25);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(21, 17);
            this.lID.TabIndex = 2;
            this.lID.Text = "ID";
            // 
            // lDescripcion
            // 
            this.lDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(368, 25);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lDescripcion.TabIndex = 3;
            this.lDescripcion.Text = "Descripcion";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(124, 22);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(233, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.Location = new System.Drawing.Point(463, 22);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(219, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(368, 117);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 28);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(463, 117);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lIdEspecialidad
            // 
            this.lIdEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lIdEspecialidad.AutoSize = true;
            this.lIdEspecialidad.Location = new System.Drawing.Point(4, 82);
            this.lIdEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIdEspecialidad.Name = "lIdEspecialidad";
            this.lIdEspecialidad.Size = new System.Drawing.Size(105, 17);
            this.lIdEspecialidad.TabIndex = 6;
            this.lIdEspecialidad.Text = "ID Especialidad";
            // 
            // cmbIdEspecialidad
            // 
            this.cmbIdEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbIdEspecialidad.FormattingEnabled = true;
            this.cmbIdEspecialidad.Location = new System.Drawing.Point(124, 79);
            this.cmbIdEspecialidad.Name = "cmbIdEspecialidad";
            this.cmbIdEspecialidad.Size = new System.Drawing.Size(233, 24);
            this.cmbIdEspecialidad.TabIndex = 8;
            this.cmbIdEspecialidad.Text = "Elija el ID de la Especialidad";
            // 
            // PlanDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(704, 155);
            this.Controls.Add(this.tlEspecialidadDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlanDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanDesktop";
            this.tlEspecialidadDesktop.ResumeLayout(false);
            this.tlEspecialidadDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlEspecialidadDesktop;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lIdEspecialidad;
        private System.Windows.Forms.ComboBox cmbIdEspecialidad;
    }
}