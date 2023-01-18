using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Entregas
{
    class EntregasConsultarView
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string CEP { get; set; }
        public int NumeroCasa { get; set; }
        public int IdPedido { get; set; }

    }
}
