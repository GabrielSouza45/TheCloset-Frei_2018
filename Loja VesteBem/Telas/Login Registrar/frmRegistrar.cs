using Loja_VesteBem.DB.Registrar_usuario;
using Loja_VesteBem.Telas.Menu;
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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifica se tem @ e . no e-mail
                if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains("."))
                {
                    //Divide em antes e depois do @
                    string[] campos = txtEmail.Text.Split('@');

                    //se tiver mais que 1 arroba, não é valido
                    if (campos.Length != 2)
                    {
                        MessageBox.Show("Esse Email parece estar incorreto.");
                    }
                    //se for menor que 4 caracteres, tá errado
                    if (campos[0].Length < 3)
                    {
                        MessageBox.Show("Esse Email parece estar incorreto.");
                    }
                    //Agora eu pego depois do arroba e divido os pontos
                    if (!campos[1].Contains("."))
                    {
                        MessageBox.Show("Esse Email parece estar incorreto.");

                        campos = campos[1].Split('.');
                    }
                    //se for menor que 4, é falso
                    if (campos[0].Length < 3)
                    {
                        MessageBox.Show("Esse Email parece estar incorreto.");

                    }

                    if (txtNome.Text == string.Empty)
                    {
                        MessageBox.Show("Nome é obrigatório.");
                        return;
                    }

                    if (txtCPF.Text == string.Empty)
                    {
                        MessageBox.Show("CPF é obrigatório.");
                        return;
                    }

                    if (txtTelefone.Text == string.Empty)
                    {
                        MessageBox.Show("Telefone é obrigatório.");
                        return;
                    }

                    if (txtCelularReg.Text == string.Empty)
                    {
                        MessageBox.Show("Celular é obrigatório.");
                        return;
                    }

                    if (txtEmail.Text == string.Empty)
                    {
                        MessageBox.Show("Login (E-mail) é obrigatório.");
                        return;
                    }

                    if (txtSenhaReg.Text == string.Empty)
                    {
                        MessageBox.Show("Senha é obrigatório.");
                        return;
                    }

                    UsuarioDTO dto = new UsuarioDTO();

                    dto.Nome = txtNome.Text;
                    dto.CPF = txtCPF.Text;
                    dto.Telefone = txtTelefone.Text;
                    dto.Celular = txtCelularReg.Text;
                    dto.Login = txtEmail.Text;
                    dto.Senha = txtSenhaReg.Text;

                    UsuarioDatabase db = new UsuarioDatabase();

                    List<UsuarioDTO> usuario = db.consultar(dto.Nome);
                    if (usuario.Count > 0)
                    {
                        MessageBox.Show("Usuário com mesmo nome já cadastrado.");
                        return;
                    }

                    UsuarioBusiness business = new UsuarioBusiness();
                    dto.IdUsuario = business.Salvar(dto);

                    MessageBox.Show("Cadastro realizado com sucesso.", "TheCloset",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    UserSession.UsuarioLogado = dto;

                    frmMenuCliente tela = new frmMenuCliente();
                    tela.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Esse Email parece estar incorreto.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo de errado não está certo!?" + ex);

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVoltarMenuADMFornecedores_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            this.Hide();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                //Verifica se tem @ e . no e-mail
                if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains("."))
                {
                    //Divide em antes e depois do @
                    string[] campos = txtEmail.Text.Split('@');

                    //se tiver mais que 1 arroba, não é valido
                    if (campos.Length != 2)
                    {
                        MessageBox.Show("Esse Email parece estar incorreto.");
                    }
                    //se for menor que 4 caracteres, tá errado
                    if (campos[0].Length < 3)
                    {
                        MessageBox.Show("Esse Email parece estar incorreto.");
                    }
                    //Agora eu pego depois do arroba e divido os pontos
                    if (!campos[1].Contains("."))
                    {
                        MessageBox.Show("Esse Email parece estar incorreto.");

                        campos = campos[1].Split('.');
                    }
                    //se for menor que 4, é falso
                    if (campos[0].Length < 3)
                    {
                        MessageBox.Show("Esse Email parece estar incorreto.");

                    }
                }
                else
                {
                    MessageBox.Show("Esse Email parece estar incorreto.");
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo de errado não está certo!?" + ex);

            }
        }
    }
}
