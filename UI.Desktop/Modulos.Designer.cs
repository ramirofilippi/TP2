
namespace UI.Desktop
{
    partial class Modulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulos));
            this.tcModulos = new System.Windows.Forms.ToolStripContainer();
            this.tlModulos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvModulos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsModulos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcModulos.ContentPanel.SuspendLayout();
            this.tcModulos.TopToolStripPanel.SuspendLayout();
            this.tcModulos.SuspendLayout();
            this.tlModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
            this.tsModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcModulos
            // 
            // 
            // tcModulos.ContentPanel
            // 
            this.tcModulos.ContentPanel.Controls.Add(this.tlModulos);
            this.tcModulos.ContentPanel.Size = new System.Drawing.Size(800, 423);
            this.tcModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcModulos.Location = new System.Drawing.Point(0, 0);
            this.tcModulos.Name = "tcModulos";
            this.tcModulos.Size = new System.Drawing.Size(800, 450);
            this.tcModulos.TabIndex = 0;
            this.tcModulos.Text = "toolStripContainer1";
            // 
            // tcModulos.TopToolStripPanel
            // 
            this.tcModulos.TopToolStripPanel.Controls.Add(this.tsModulos);
            // 
            // tlModulos
            // 
            this.tlModulos.ColumnCount = 2;
            this.tlModulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlModulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlModulos.Controls.Add(this.dgvModulos, 0, 0);
            this.tlModulos.Controls.Add(this.btnActualizar, 0, 1);
            this.tlModulos.Controls.Add(this.btnSalir, 1, 1);
            this.tlModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlModulos.Location = new System.Drawing.Point(0, 0);
            this.tlModulos.Name = "tlModulos";
            this.tlModulos.RowCount = 2;
            this.tlModulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlModulos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlModulos.Size = new System.Drawing.Size(800, 423);
            this.tlModulos.TabIndex = 0;
            // 
            // dgvModulos
            // 
            this.dgvModulos.AllowUserToAddRows = false;
            this.dgvModulos.AllowUserToDeleteRows = false;
            this.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion});
            this.tlModulos.SetColumnSpan(this.dgvModulos, 2);
            this.dgvModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModulos.Location = new System.Drawing.Point(3, 3);
            this.dgvModulos.MultiSelect = false;
            this.dgvModulos.Name = "dgvModulos";
            this.dgvModulos.ReadOnly = true;
            this.dgvModulos.RowHeadersWidth = 51;
            this.dgvModulos.RowTemplate.Height = 24;
            this.dgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModulos.Size = new System.Drawing.Size(794, 388);
            this.dgvModulos.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(634, 397);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(722, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsModulos
            // 
            this.tsModulos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsModulos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsModulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsModulos.Location = new System.Drawing.Point(4, 0);
            this.tsModulos.Name = "tsModulos";
            this.tsModulos.Size = new System.Drawing.Size(100, 27);
            this.tsModulos.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(29, 24);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(29, 24);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(29, 24);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Modulos
            // 
            this.AcceptButton = this.btnActualizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcModulos);
            this.Name = "Modulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulos";
            this.Load += new System.EventHandler(this.Modulos_Load);
            this.tcModulos.ContentPanel.ResumeLayout(false);
            this.tcModulos.TopToolStripPanel.ResumeLayout(false);
            this.tcModulos.TopToolStripPanel.PerformLayout();
            this.tcModulos.ResumeLayout(false);
            this.tcModulos.PerformLayout();
            this.tlModulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
            this.tsModulos.ResumeLayout(false);
            this.tsModulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcModulos;
        private System.Windows.Forms.ToolStrip tsModulos;
        private System.Windows.Forms.TableLayoutPanel tlModulos;
        private System.Windows.Forms.DataGridView dgvModulos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}