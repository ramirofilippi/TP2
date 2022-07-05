
namespace UI.Desktop
{
    partial class Menu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoModulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPlanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 254);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalir.Location = new System.Drawing.Point(262, 224);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.especialidadesToolStripMenuItem,
            this.modulosToolStripMenuItem,
            this.planesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // listadoUsuariosToolStripMenuItem
            // 
            this.listadoUsuariosToolStripMenuItem.Name = "listadoUsuariosToolStripMenuItem";
            this.listadoUsuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listadoUsuariosToolStripMenuItem.Text = "Listado Usuarios";
            this.listadoUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listadoUsuariosToolStripMenuItem_Click);
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoEspecialidadesToolStripMenuItem});
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.especialidadesToolStripMenuItem.Text = "Especialidades";
            // 
            // listadoEspecialidadesToolStripMenuItem
            // 
            this.listadoEspecialidadesToolStripMenuItem.Name = "listadoEspecialidadesToolStripMenuItem";
            this.listadoEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.listadoEspecialidadesToolStripMenuItem.Text = "Listado Especialidades";
            this.listadoEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.listadoEspecialidadesToolStripMenuItem_Click);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoModulosToolStripMenuItem});
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.modulosToolStripMenuItem.Text = "Modulos";
            // 
            // listadoModulosToolStripMenuItem
            // 
            this.listadoModulosToolStripMenuItem.Name = "listadoModulosToolStripMenuItem";
            this.listadoModulosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listadoModulosToolStripMenuItem.Text = "Listado Modulos";
            this.listadoModulosToolStripMenuItem.Click += new System.EventHandler(this.listadoModulosToolStripMenuItem_Click);
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoPlanesToolStripMenuItem});
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.planesToolStripMenuItem.Text = "Planes";
            // 
            // listadoPlanesToolStripMenuItem
            // 
            this.listadoPlanesToolStripMenuItem.Name = "listadoPlanesToolStripMenuItem";
            this.listadoPlanesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listadoPlanesToolStripMenuItem.Text = "Listado Planes";
            this.listadoPlanesToolStripMenuItem.Click += new System.EventHandler(this.listadoPlanesToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(624, 284);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoModulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoPlanesToolStripMenuItem;
    }
}