using Loja_VesteBem.BASE;
using Loja_VesteBem.DB.Produto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Fornecedores
{
    public class ProdutoDatabase
    {
        public int Salvar(ProdutoDTO produto)
        {
            string script =
            @"INSERT INTO tb_produto (id_produto , nm_produto , vl_preco, id_fornecedor)
                VALUES (@id_produto , @nm_produto , @vl_preco, @id_fornecedor)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", produto.Id));
            parms.Add(new MySqlParameter("nm_produto", produto.Nome));
            parms.Add(new MySqlParameter("vl_preco", produto.Preco));
            parms.Add(new MySqlParameter("id_fornecedor", produto.IdFornecedor));
            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public void Alterar(ProdutoDTO produto)
        {
            string script =
            @"UPDATE tb_produto SET nm_produto = @nm_produto,
                vl_produto = @vl_produto,
                WHERE id_produto = @id_produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", produto.Id));
            parms.Add(new MySqlParameter("nm_produto", produto.Nome));
            parms.Add(new MySqlParameter("vl_produto", produto.Preco));
            parms.Add(new MySqlParameter("id_fornecedor", produto.IdFornecedor));
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public void Remover(int idproduto)
        {
            string script =
            @"DELETE FROM tb_produto WHERE id_produto = @id_produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", idproduto));
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<ProdutoDTO> Listar()
        {
            string script =
            @"SELECT * FROM tb_produto";
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            while (reader.Read())
            {
                ProdutoDTO produto = new ProdutoDTO();
                produto.Id = reader.GetInt32("id_produto");
                produto.Nome = reader.GetString("nm_produto");
                produto.Preco = reader.GetDecimal("vl_preco");
                produto.IdFornecedor = reader.GetInt32("id_fornecedor");

                produtos.Add(produto);
            }
            reader.Close();
            return produtos;
        }
        public List<ProdutoConsultarView> Consultar(string produto)
        {
            string script = @"SELECT * FROM VW_PRODUTO_CONSULTA WHERE nm_produto like @nm_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto", "%" + produto + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoConsultarView> lista = new List<ProdutoConsultarView>();
            while (reader.Read())
            {
                ProdutoConsultarView dto = new ProdutoConsultarView();
                dto.Id = reader.GetInt32("id_produto");
                dto.Nome = reader.GetString("nm_produto");
                dto.Preco = reader.GetDecimal("vl_preco");
                dto.Fornecedor = reader.GetString("nm_fornecedor");
                

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
