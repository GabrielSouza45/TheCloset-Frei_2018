using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Pedido
{
    public class PedidoConsultarView
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public int QtdItens { get; set; }
        public DateTime Data { get; set; }
        public decimal Total { get; set; }
    }
}

