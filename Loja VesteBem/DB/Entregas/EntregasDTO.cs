using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Entregas
{
    public class EntregasDTO
    {
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public int IdEndereco { get; set; }

        public int IdCliente { get; set; }
    }
}
