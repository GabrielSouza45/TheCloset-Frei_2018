using Loja_VesteBem.DB;
using Loja_VesteBem.DB.Fornecedores;
using Loja_VesteBem.DB.Produto;
using Loja_VesteBem.Telas.Menu_ADM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_VesteBem.Telas.Consultar_Produtos_ADM
{
    public partial class frmConsultarProdutoADM : Form
    {
        public frmConsultarProdutoADM()
        {
            InitializeComponent();
        }

        private void btnVoltarMenuADMFornecedores_Click(object sender, EventArgs e)
        {
            frmMenuADM tela = new frmMenuADM();
            tela.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                ProdutoConsultarView produto = dataGridView1.Rows[e.RowIndex].DataBoundItem as ProdutoConsultarView;

                DialogResult r = MessageBox.Show($"Deseja realmente excluir o produto {produto.Id}?", "The Closet",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    ProdutoBusiness business = new ProdutoBusiness();
                    business.Remover(produto.Id);

                    button1_Click(null, null);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoBusiness business = new ProdutoBusiness();
                List<ProdutoConsultarView> lista = business.Consultar(textBox1.Text.Trim());

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = lista;
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

        private void frmConsultarProdutoADM_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
