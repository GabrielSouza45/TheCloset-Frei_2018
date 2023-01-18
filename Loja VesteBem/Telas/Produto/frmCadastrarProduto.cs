using Loja_VesteBem.DB;
using Loja_VesteBem.DB.Fornecedores;
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

namespace Loja_VesteBem.Telas
{
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            FornecedorBusiness busca = new FornecedorBusiness();
            List<FornecedorDTO> lista = busca.Listar();

            cboFornecedorProduto.ValueMember = nameof(FornecedorDTO.Id);
            cboFornecedorProduto.DisplayMember = nameof(FornecedorDTO.Nome);
            cboFornecedorProduto.DataSource = lista;
        }

        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text == string.Empty)
            {
                MessageBox.Show("Nome é obrigatório.");
                return;
            }
            if (txtPrecoProduto.Text == string.Empty)
            {
                MessageBox.Show("Preço é obrigatório.");
                return;
            }
            if (cboFornecedorProduto.Text == string.Empty)
            {
                MessageBox.Show("Defina Fornecedor.");
                return;
            }

            
            try
            {
                FornecedorDTO fornecedor = cboFornecedorProduto.SelectedItem as FornecedorDTO;

                ProdutoDTO dto = new ProdutoDTO();
                dto.Nome = txtNomeProduto.Text.Trim();
                dto.Preco = Convert.ToDecimal(txtPrecoProduto.Text.Trim());
                dto.IdFornecedor = fornecedor.Id;

                

                ProdutoBusiness Business = new ProdutoBusiness();

                //List<ProdutoDTO> produtos = Business.Consultar(dto.Nome);
                //if (produtos.Count > 0)
                //{
                //    throw new ArgumentException("Produto com mesmo nome já cadastrado.");
                //}

                Business.Salvar(dto);

                MessageBox.Show("Produto salvo com sucesso.", "TheCloset",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "TheCloset",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception )
            {
                MessageBox.Show("Ocorreru um erro, tente mais tarde.", "TheCloset",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltarMenuADMFornecedores_Click(object sender, EventArgs e)
        {
            frmMenuADM tela = new frmMenuADM();
            tela.Show();
            this.Close();
        }
    }
}
