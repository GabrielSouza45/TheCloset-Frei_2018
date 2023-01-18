using Loja_VesteBem.Telas.Cadastrar_Adiministrador;
using Loja_VesteBem.Telas.Consultar_Cliente_ADM;
using Loja_VesteBem.Telas.Consultar_Fornecedores;
using Loja_VesteBem.Telas.Consultar_pedido;
using Loja_VesteBem.Telas.Consultar_Produtos;
using Loja_VesteBem.Telas.Consultar_Produtos_ADM;
using Loja_VesteBem.Telas.Fornecedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_VesteBem.Telas.Menu_ADM
{
    public partial class frmMenuADM : Form
    {
        public frmMenuADM()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmConsultarCliente tel = new frmConsultarCliente();
            tel.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto telaregistrar = new frmCadastrarProduto();
            telaregistrar.Show();
            this.Hide();
            
        }

        private void btnGerenciarProdutosADM_Click(object sender, EventArgs e)
        {
            frmConsultarProdutoADM tela = new frmConsultarProdutoADM();
            tela.Show();
            this.Hide();
        }

        private void btnGerenciarPedidosADM_Click(object sender, EventArgs e)
        {
            frmConsultarPedidos telaregistrar = new frmConsultarPedidos();
            telaregistrar.Show();
            this.Hide();
        }

        private void btnGerenciarFornecedoresADM_Click(object sender, EventArgs e)
        {
            frmConsultarFornecedores telaregistrar = new frmConsultarFornecedores();
            telaregistrar.Show();
            this.Hide();
           
        }

        private void btnCadastrarNovoFornecedorADM_Click(object sender, EventArgs e)
        {
            frmCadastrarFornecedores telaregistrar = new frmCadastrarFornecedores();
            telaregistrar.Show();
            this.Hide();
            
        }

        private void btnCadastrarNovoAdiministradorADM_Click(object sender, EventArgs e)
        {
            frmCadastrarADM telaregistrar = new frmCadastrarADM();
            telaregistrar.Show();
            this.Hide();
            
        }

        private void logOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin tela = new frmLogin();
            tela.Show();
            this.Close();
        }

        private void frmMenuADM_Load(object sender, EventArgs e)
        {

        }
    }
}
