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

namespace Loja_VesteBem.Telas.Fornecedores
{
    public partial class frmCadastrarFornecedores : Form
    {
        public frmCadastrarFornecedores()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text == string.Empty)
            {
                MessageBox.Show("Nome é obrigatório.");
                return ;
            }
            if (txtTelefoneFornecedor.Text == string.Empty)
            {
                MessageBox.Show("Telefone é obrigatório.");
                return;
            }
            if (txtEnderecoFornecedor.Text == string.Empty)
            {
                MessageBox.Show("Endereço é obrigatório.");
                return;
            }

            FornecedorDatabase db = new FornecedorDatabase();

            List<FornecedorDTO> produtos = db.consultar(txtNomeFornecedor.Text);
            if (produtos.Count > 0)
            {
                MessageBox.Show("Fornecedor já cadastrado.");
                return;
            }

            FornecedorDTO dto = new FornecedorDTO();
            dto.Nome = txtNomeFornecedor.Text;
            dto.Telefone = txtTelefoneFornecedor.Text;
            dto.Endereco = txtEnderecoFornecedor.Text;

            FornecedorBusiness business = new FornecedorBusiness();
            dto.Id = business.Salvar(dto);

            MessageBox.Show("Fornecedor cadastrado com sucesso!");
        }

        private void btnVoltarMenuADMFornecedores_Click(object sender, EventArgs e)
        {
            frmMenuADM tela = new frmMenuADM();
            tela.Show();
            this.Close();
        }

        private void frmCadastrarFornecedores_Load(object sender, EventArgs e)
        {

        }
    }
}
