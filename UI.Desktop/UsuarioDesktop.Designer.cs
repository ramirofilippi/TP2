
namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.tlUsuarioDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lClave = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lConfirmarClave = new System.Windows.Forms.Label();
            this.tlUsuarioDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlUsuarioDesktop
            // 
            this.tlUsuarioDesktop.ColumnCount = 4;
            this.tlUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.71658F));
            this.tlUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.28342F));
            this.tlUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tlUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tlUsuarioDesktop.Controls.Add(this.lId, 0, 0);
            this.tlUsuarioDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlUsuarioDesktop.Controls.Add(this.txtNombre, 1, 1);
            this.tlUsuarioDesktop.Controls.Add(this.txtEmail, 1, 2);
            this.tlUsuarioDesktop.Controls.Add(this.txtClave, 1, 3);
            this.tlUsuarioDesktop.Controls.Add(this.txtApellido, 3, 1);
            this.tlUsuarioDesktop.Controls.Add(this.txtUsuario, 3, 2);
            this.tlUsuarioDesktop.Controls.Add(this.txtConfirmarClave, 3, 3);
            this.tlUsuarioDesktop.Controls.Add(this.chkHabilitado, 2, 0);
            this.tlUsuarioDesktop.Controls.Add(this.btnAceptar, 2, 4);
            this.tlUsuarioDesktop.Controls.Add(this.btnCancelar, 3, 4);
            this.tlUsuarioDesktop.Controls.Add(this.lNombre, 0, 1);
            this.tlUsuarioDesktop.Controls.Add(this.lEmail, 0, 2);
            this.tlUsuarioDesktop.Controls.Add(this.lClave, 0, 3);
            this.tlUsuarioDesktop.Controls.Add(this.lApellido, 2, 1);
            this.tlUsuarioDesktop.Controls.Add(this.lUsuario, 2, 2);
            this.tlUsuarioDesktop.Controls.Add(this.lConfirmarClave, 2, 3);
            this.tlUsuarioDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUsuarioDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlUsuarioDesktop.Name = "tlUsuarioDesktop";
            this.tlUsuarioDesktop.RowCount = 5;
            this.tlUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tlUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tlUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlUsuarioDesktop.Size = new System.Drawing.Size(750, 224);
            this.tlUsuarioDesktop.TabIndex = 0;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(3, 0);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(21, 17);
            this.lId.TabIndex = 0;
            this.lId.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(73, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(297, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(297, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(73, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(73, 130);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(297, 22);
            this.txtClave.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(493, 45);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(253, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(493, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(493, 130);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(253, 22);
            this.txtConfirmarClave.TabIndex = 7;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(376, 3);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(93, 21);
            this.chkHabilitado.TabIndex = 8;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(376, 176);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(493, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(3, 42);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(58, 17);
            this.lNombre.TabIndex = 11;
            this.lNombre.Text = "Nombre";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(3, 86);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(42, 17);
            this.lEmail.TabIndex = 12;
            this.lEmail.Text = "Email";
            // 
            // lClave
            // 
            this.lClave.AutoSize = true;
            this.lClave.Location = new System.Drawing.Point(3, 127);
            this.lClave.Name = "lClave";
            this.lClave.Size = new System.Drawing.Size(43, 17);
            this.lClave.TabIndex = 13;
            this.lClave.Text = "Clave";
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(376, 42);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(58, 17);
            this.lApellido.TabIndex = 14;
            this.lApellido.Text = "Apellido";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(376, 86);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(57, 17);
            this.lUsuario.TabIndex = 15;
            this.lUsuario.Text = "Usuario";
            // 
            // lConfirmarClave
            // 
            this.lConfirmarClave.AutoSize = true;
            this.lConfirmarClave.Location = new System.Drawing.Point(376, 127);
            this.lConfirmarClave.Name = "lConfirmarClave";
            this.lConfirmarClave.Size = new System.Drawing.Size(108, 17);
            this.lConfirmarClave.TabIndex = 16;
            this.lConfirmarClave.Text = "Confirmar Clave";
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 224);
            this.Controls.Add(this.tlUsuarioDesktop);
            this.Name = "UsuarioDesktop";
            this.Text = "Usuario";
            this.tlUsuarioDesktop.ResumeLayout(false);
            this.tlUsuarioDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlUsuarioDesktop;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lClave;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lConfirmarClave;
    }
}