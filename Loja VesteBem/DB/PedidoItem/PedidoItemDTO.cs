using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB
{
    class PedidoItemDTO
    {
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public int IdProduto { get; set; }
    }
}
