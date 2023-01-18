using Loja_VesteBem.DB;
using Loja_VesteBem.DB.Fornecedores;
using Loja_VesteBem.DB.Pedido;
using Loja_VesteBem.DB.Registrar_usuario;
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

namespace Loja_VesteBem.Telas.Consultar_pedido
{
    public partial class frmConsultarPedidos : Form
    {
        public frmConsultarPedidos()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoBusiness business = new PedidoBusiness();
                List<PedidoConsultarView> lista = business.Consultar(txtConsultarCliente.Text.Trim());

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

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.ColumnIndex == 5)
            {
                PedidoConsultarView pedido = dgvPedidos.Rows[e.RowIndex].DataBoundItem as PedidoConsultarView;

                DialogResult r = MessageBox.Show($"Deseja realmente excluir o pedido {pedido.Id}?", "DBZ",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    PedidoBusiness business = new PedidoBusiness();
                    business.Remover(pedido.Id);

                    button1_Click(null, null);
                }
            }
        }
    }
}
