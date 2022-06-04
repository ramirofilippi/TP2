using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Listar(object sender, EventArgs e)
        {
            UsuarioLogic usuario = new UsuarioLogic();
            this.dgvUsuarios.DataSource = usuario.GetAll();
        }
    }
}
