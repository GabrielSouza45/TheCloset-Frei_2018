using Loja_VesteBem.DB.Entregas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_VesteBem.Telas.Entrega
{
    public partial class frmEntregas : Form
    {
        public frmEntregas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarEntrega_Click(object sender, EventArgs e)
        {
            try
            {
                EntregasBusiness business = new EntregasBusiness();
                List<EntregasConsultarView> lista = business.Consultar(txtEntrega.Text.Trim());

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
    }
}
