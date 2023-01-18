using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Fornecedores
{
    class FornecedorBusiness
    {
        public int Salvar(FornecedorDTO fornecedor)
        {
            FornecedorDatabase database = new FornecedorDatabase();
            int id = database.Salvar(fornecedor);
            return id; 
        }

        public List<FornecedorDTO> consultar(string fornecedor)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.consultar(fornecedor);
        }
        public List<FornecedorDTO> Listar()
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.Listar();
        }
    }
}
