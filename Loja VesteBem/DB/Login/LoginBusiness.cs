using Loja_VesteBem.DB.Registrar_usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Fornecedores
{
    class LoginBusiness
    {
        public UsuarioDTO Logar(string login, string senha)
        {
            if (login == string.Empty)
            {
                throw new ArgumentException("Usuário é obrigatório.");
            }

            if (senha == string.Empty)
            {
                throw new ArgumentException("Senha é obrigatório.");
            }

            LoginDatabase db = new LoginDatabase();
            return db.Logar(login, senha);
        }
    }
}
