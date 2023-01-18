using Loja_VesteBem.DB;
using Loja_VesteBem.DB.Registrar_usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem
{
    static class UserSession
    {
        public static UsuarioDTO UsuarioLogado { get; set; }
    }
}
