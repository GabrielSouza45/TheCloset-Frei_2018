using Loja_VesteBem.BASE;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Fornecedores
{
    class FornecedorDatabase
    {
        public int Salvar(FornecedorDTO fornecedor)
        {
            string script =
            @"INSERT INTO tb_fornecedor ( nm_fornecedor , ds_telefone, ds_endereco)
                VALUES ( @nm_fornecedor , @ds_telefone, @ds_endereco)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_fornecedor", fornecedor.Nome));
            parms.Add(new MySqlParameter("ds_telefone", fornecedor.Telefone));
            parms.Add(new MySqlParameter("ds_endereco", fornecedor.Endereco));
            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public List<FornecedorDTO> consultar(string Nome)
        {
            string script =
            @"SELECT * FROM tb_Fornecedor WHERE nm_fornecedor LIKE @nm_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_fornecedor", "%" + Nome + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> lista = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO dto = new FornecedorDTO();
                dto.Id = reader.GetInt32("id_fornecedor");
                dto.Nome = reader.GetString("nm_fornecedor");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Endereco = reader.GetString("ds_endereco");

                lista.Add(dto);
            }
            reader.Close();
            return lista;
        }

        public void Alterar(FornecedorDTO fornecedor)
        {
            string script =
            @"UPDATE tb_fornecedor SET nm_fornecedor = @nm_fornecedor,
                ds_endereco = @ds_endereco,
                ds_telefone = @ds_telefone,
                WHERE id_produto = @id_produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", fornecedor.Id));
            parms.Add(new MySqlParameter("nm_produto", fornecedor.Nome));
            parms.Add(new MySqlParameter("ds_endereco", fornecedor.Endereco));
            parms.Add(new MySqlParameter("ds_telefone", fornecedor.Telefone));
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Remover(int idfornecedor)
        {
            string script =
            @"DELETE FROM tb_fornecedor WHERE id_fornecedor = @id_fornecedor";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", idfornecedor));
            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

       
        public List<FornecedorDTO> Listar()
        {
            string script = @"SELECT * FROM tb_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> lista = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO dto = new FornecedorDTO();
                dto.Id = reader.GetInt32("id_fornecedor");
                dto.Nome = reader.GetString("nm_fornecedor");
                dto.Endereco = reader.GetString("ds_endereco");
                dto.Telefone = reader.GetString("ds_telefone");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
