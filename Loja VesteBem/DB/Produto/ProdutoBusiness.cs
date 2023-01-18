using Loja_VesteBem.DB.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Fornecedores
{
    public class ProdutoBusiness
    {
        public int Salvar(ProdutoDTO produto)
        {
            ProdutoDatabase produtoDB = new ProdutoDatabase();
            int id = produtoDB.Salvar(produto);
            return id;
        }

        public void Alterar(ProdutoDTO produto)
        {
            ProdutoDatabase produtoDB = new ProdutoDatabase();
            produtoDB.Alterar(produto);
        }
      
        public void Remover(int Id)
        {
            ProdutoDatabase produtoDB = new ProdutoDatabase();
            produtoDB.Remover(Id);
           
        }

        public List<ProdutoConsultarView> Consultar(string produto)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Consultar(produto);
        }


        public List<ProdutoDTO> Listar()
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Listar();
        }

    }

}


