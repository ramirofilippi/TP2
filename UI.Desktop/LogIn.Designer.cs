
namespace UI.Desktop
{
    partial class LogIn
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
            this.lBienvenida = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lClave = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.llClave = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lBienvenida
            // 
            this.lBienvenida.AutoSize = true;
            this.lBienvenida.Location = new System.Drawing.Point(113, 24);
            this.lBienvenida.Name = "lBienvenida";
            this.lBienvenida.Size = new System.Drawing.Size(275, 34);
            this.lBienvenida.TabIndex = 0;
            this.lBienvenida.Text = "¡Bienvenido al Sistema!\r\nPor favor, digite su información de Ingreso";
            this.lBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(86, 87);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(139, 17);
            this.lUsuario.TabIndex = 1;
            this.lUsuario.Text = "Nombre de Usuario: ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(231, 84);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(262, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(231, 126);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(262, 22);
            this.txtClave.TabIndex = 3;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lClave
            // 
            this.lClave.AutoSize = true;
            this.lClave.Location = new System.Drawing.Point(174, 129);
            this.lClave.Name = "lClave";
            this.lClave.Size = new System.Drawing.Size(51, 17);
            this.lClave.TabIndex = 4;
            this.lClave.Text = "Clave: ";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(322, 167);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(76, 34);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(418, 167);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // llClave
            // 
            this.llClave.AutoSize = true;
            this.llClave.Location = new System.Drawing.Point(12, 184);
            this.llClave.Name = "llClave";
            this.llClave.Size = new System.Drawing.Size(103, 17);
            this.llClave.TabIndex = 7;
            this.llClave.TabStop = true;
            this.llClave.Text = "Olvidé mi clave";
            this.llClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClave_LinkClicked);
            // 
            // LogIn
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(512, 213);
            this.Controls.Add(this.llClave);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.lBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBienvenida;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.LinkLabel llClave;
    }
}