using Loja_VesteBem.DB.Fornecedores;
using Loja_VesteBem.DB.Pedido;
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

namespace Loja_VesteBem.Telas.Consultar_Pedidos
{
    public partial class frmConsultarPedido : Form
    {
        public frmConsultarPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoBusiness business = new PedidoBusiness();
                List<PedidoConsultarView> lista = business.Consultar(txtConsultarClienteUs.Text.Trim());

                dgvPedidos.AutoGenerateColumns = false;
                dgvPedidos.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "The Closet",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreru um erro, tente mais tarde.", "The Closet",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void frmConsultarPedido_Load(object sender, EventArgs e)
        {

        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
