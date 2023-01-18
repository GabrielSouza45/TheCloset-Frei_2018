using Loja_VesteBem.Telas.Consultar_pedido;
using Loja_VesteBem.Telas.Consultar_Pedidos;
using Loja_VesteBem.Telas.Consultar_Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_VesteBem.Telas.Menu_Cliente
{
    public partial class frmMenuCliente : Form
    {
        public frmMenuCliente()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarPedido tela = new frmCadastrarPedido();
            tela.Show();
            this.Hide();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarPedido tela = new frmConsultarPedido();
            tela.Show();
            this.Hide();
        }

        private void consultarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarProdutos tela = new frmConsultarProdutos();
            tela.Show();
            this.Hide();
        }

        private void logOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin tela = new frmLogin();
            tela.Show();
            this.Close();
        }
    }
}
