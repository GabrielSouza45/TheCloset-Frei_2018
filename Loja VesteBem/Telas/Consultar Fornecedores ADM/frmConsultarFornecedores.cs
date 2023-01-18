using Loja_VesteBem.DB;
using Loja_VesteBem.DB.Fornecedor;
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

namespace Loja_VesteBem.Telas.Consultar_Fornecedores
{
    public partial class frmConsultarFornecedores : Form
    {
        public frmConsultarFornecedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                FornecedorBusiness business = new FornecedorBusiness();
                List<FornecedorDTO> lista = business.consultar(txtFornecedor.Text.Trim());

                dgvFornecedores.AutoGenerateColumns = false;
                dgvFornecedores.DataSource = lista;
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

        private void dgvFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVoltarMenuADMFornecedores_Click(object sender, EventArgs e)
        {
           

        }

        private void btnVoltarMenuADMFornecedores_Click_1(object sender, EventArgs e)
        {
            frmMenuADM tela = new frmMenuADM();
            tela.Show();
            this.Close();
        }
    }
}
