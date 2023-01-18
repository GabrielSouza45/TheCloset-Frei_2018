using Loja_VesteBem.DB;
using Loja_VesteBem.DB.Fornecedores;
using Loja_VesteBem.DB.Registrar_usuario;
using Loja_VesteBem.Telas.Menu;
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

namespace Loja_VesteBem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LoginBusiness business = new LoginBusiness();
                UsuarioDTO usuario = business.Logar(txtLogin.Text, txtSenha.Text);

                if (usuario != null)
                {
                    UserSession.UsuarioLogado = usuario;

                    if (usuario.Adiministrador == true)
                    {
                        frmMenuADM menu = new frmMenuADM();
                        menu.Show();
                    }
                    else
                    {
                        frmMenuCliente menu = new frmMenuCliente();
                        menu.Show();
                    }
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas.", "TheCloset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

        private void lblLoginNome_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistrar telaregistrar = new frmRegistrar();
            telaregistrar.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarMenuADMFornecedores_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            this.Hide();
        }
    }
}
