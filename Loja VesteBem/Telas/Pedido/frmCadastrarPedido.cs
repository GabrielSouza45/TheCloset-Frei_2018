using Loja_VesteBem.DB;
using Loja_VesteBem.DB.Fornecedores;
using Loja_VesteBem.DB.Produto;
using Loja_VesteBem.DB.Registrar_usuario;
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

namespace Loja_VesteBem.Telas
{
    public partial class frmCadastrarPedido : Form
    {
        BindingList<ProdutoDTO> produtosCarrinho = new BindingList<ProdutoDTO>();

        public frmCadastrarPedido()
        {
            InitializeComponent();
            CarregarCombos();
            ConfigurarGrid();
        }
        void CarregarCombos()
        {
            ProdutoBusiness business = new ProdutoBusiness();
            List<ProdutoDTO> lista = business.Listar();

            cboProduto.ValueMember = nameof(ProdutoDTO.Id);
            cboProduto.DisplayMember = nameof(ProdutoDTO.Nome);
            cboProduto.DataSource = lista;
        }
        void ConfigurarGrid()
        {
            dgvItens.AutoGenerateColumns = false;
            dgvItens.DataSource = produtosCarrinho;
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO dto = cboProduto.SelectedItem as ProdutoDTO;

                int qtd = Convert.ToInt32(txtQuantidade.Text);

                for (int i = 0; i < qtd; i++)
                {
                    produtosCarrinho.Add(dto);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "The Closet",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreru um erro, tente mais tarde.", "The CLoset",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            

            PedidoDTO dto = new PedidoDTO();
            dto.IdCliente = UserSession.UsuarioLogado.IdUsuario;
            dto.Data = DateTime.Now;

            PedidoBusiness business = new PedidoBusiness();
            business.Salvar(dto, produtosCarrinho.ToList());

            MessageBox.Show("Pedido salvo com sucesso.", "The Closet", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVoltarMenuADMFornecedores_Click(object sender, EventArgs e)
        {
            frmMenuCliente tela = new frmMenuCliente();
            tela.Show();
            this.Close();
        }

        private void frmCadastrarPedido_Load(object sender, EventArgs e)
        {

        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
