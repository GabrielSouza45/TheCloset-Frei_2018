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

namespace Loja_VesteBem.Telas.Cadastrar_Adiministrador
{
    public partial class frmCadastrarADM : Form
    {
        public frmCadastrarADM()
        {
            InitializeComponent();
        }

        private void chkAdministrador_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void btnRegistrarDfn_Click(object sender, EventArgs e)
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

                    UsuarioDTO dto = new UsuarioDTO();


                    dto.Nome = txtNome.Text;
                    dto.CPF = txtCPF.Text;
                    dto.Telefone = txtTelefone.Text;
                    dto.Celular = txtCelularReg.Text;
                    dto.Login = txtEmail.Text;
                    dto.Senha = txtSenhaReg.Text;
                    dto.Adiministrador = true;

                    UsuarioBusiness business = new UsuarioBusiness();
                    dto.IdUsuario = business.Salvar(dto);

                    MessageBox.Show("Cadastro realizado com sucesso.", "TheCloset",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


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

        private void btnVoltarMenuADMFornecedores_Click(object sender, EventArgs e)
        {
            frmMenuADM tela = new frmMenuADM();
            tela.Show();
            this.Hide();
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {

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

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
