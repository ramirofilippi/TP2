
namespace UI.Desktop
{
    partial class EspecialidadDesktop
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.tlEspecialidadDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlEspecialidadDesktop
            // 
            this.tlEspecialidadDesktop.ColumnCount = 4;
            this.tlEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.43836F));
            this.tlEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.56165F));
            this.tlEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tlEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tlEspecialidadDesktop.Controls.Add(this.lID, 0, 0);
            this.tlEspecialidadDesktop.Controls.Add(this.lDescripcion, 2, 0);
            this.tlEspecialidadDesktop.Controls.Add(this.btnAceptar, 2, 1);
            this.tlEspecialidadDesktop.Controls.Add(this.btnCancelar, 3, 1);
            this.tlEspecialidadDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlEspecialidadDesktop.Controls.Add(this.txtDescripcion, 3, 0);
            this.tlEspecialidadDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlEspecialidadDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlEspecialidadDesktop.Name = "tlEspecialidadDesktop";
            this.tlEspecialidadDesktop.RowCount = 2;
            this.tlEspecialidadDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.1068F));
            this.tlEspecialidadDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.8932F));
            this.tlEspecialidadDesktop.Size = new System.Drawing.Size(652, 90);
            this.tlEspecialidadDesktop.TabIndex = 1;
            // 
            // lID
            // 
            this.lID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(3, 19);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(21, 17);
            this.lID.TabIndex = 2;
            this.lID.Text = "ID";
            // 
            // lDescripcion
            // 
            this.lDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(299, 19);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lDescripcion.TabIndex = 3;
            this.lDescripcion.Text = "Descripcion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(299, 59);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 28);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(398, 59);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(51, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(233, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.Location = new System.Drawing.Point(398, 17);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(236, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // EspecialidadDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(652, 90);
            this.Controls.Add(this.tlEspecialidadDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EspecialidadDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EspecialidadDesktop";
            this.tlEspecialidadDesktop.ResumeLayout(false);
            this.tlEspecialidadDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlEspecialidadDesktop;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}