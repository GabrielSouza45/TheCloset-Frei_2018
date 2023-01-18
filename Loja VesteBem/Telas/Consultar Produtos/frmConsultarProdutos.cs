using Loja_VesteBem.DB;
using Loja_VesteBem.DB.Fornecedores;
using Loja_VesteBem.DB.Produto;
using Loja_VesteBem.Telas.Menu_ADM;
using Loja_VesteBem.Telas.Menu_Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_VesteBem.Telas.Consultar_Produtos
{
    public partial class frmConsultarProdutos : Form
    {
        public frmConsultarProdutos()
        {
            InitializeComponent();
           
        }

        private void btnVoltarMenuADMFornecedores_Click(object sender, EventArgs e)
        {
            if (UserSession.UsuarioLogado.Adiministrador == true)
            {
                frmMenuADM tela = new frmMenuADM();
                tela.Show();
                this.Close();
            }
            else
            {
                frmMenuCliente tela = new frmMenuCliente();
                tela.Show();
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoBusiness business = new ProdutoBusiness();
                List<ProdutoConsultarView> lista = business.Consultar(txtProduto.Text.Trim());

                dgvProdutos.AutoGenerateColumns = false;
                dgvProdutos.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "The CLoset",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreru um erro, tente mais tarde.", "The CLoset",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            


        }

        private void frmConsultarProdutos_Load(object sender, EventArgs e)
        {
           
        }
    }
}
