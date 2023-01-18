using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Registrar_usuario
{
    class UsuarioDTO
    {
        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public bool Adiministrador { get; set; }

        public int EndereçoId { get; set; }
    }
}
