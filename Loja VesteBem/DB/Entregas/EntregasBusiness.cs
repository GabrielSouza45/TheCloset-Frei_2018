using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Entregas
{
    class EntregasBusiness
    {
        public List<EntregasConsultarView> Consultar(string entregas)
        {
            EntregasDatabase db = new EntregasDatabase();
            return db.Consultar(entregas);
        }
      
        

        public List<EntregasConsultarView> Listar()
        {
            EntregasDatabase db = new EntregasDatabase();
            return db.Listar();
        }
    }
}
