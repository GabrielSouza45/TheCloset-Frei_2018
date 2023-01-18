using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB
{
    public class PedidoDTO
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public DateTime Data { get; set; }

    }
}
