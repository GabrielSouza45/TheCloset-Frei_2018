using Loja_VesteBem.DB.Registrar_usuario;
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

namespace Loja_VesteBem.Telas.Consultar_Cliente_ADM
{
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void dgvFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBusiness business = new UsuarioBusiness();
                List<UsuarioDTO> lista = business.Consultar(txtClienteCon.Text);

                dgvCliente.AutoGenerateColumns = false;
                dgvCliente.DataSource = lista;
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
            frmMenuADM tela = new frmMenuADM();
            tela.Show();
            this.Hide();
        }
    }
}
