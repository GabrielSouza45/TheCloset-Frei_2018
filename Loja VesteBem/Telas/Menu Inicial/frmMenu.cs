using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_VesteBem.Telas.Menu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin telalogin = new frmLogin();
            telalogin.Show();
            this.Hide();
        }

        private void adiministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrar telaregistrar = new frmRegistrar();
            telaregistrar.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
         
        }
    }
}
