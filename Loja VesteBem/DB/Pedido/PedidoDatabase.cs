    using Loja_VesteBem.BASE;
using Loja_VesteBem.DB.Pedido;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Loja_VesteBem.DB.Fornecedores
{
    public class PedidoDatabase
    {
        public int Salvar(PedidoDTO dto)
        {
            string script = @"INSERT INTO tb_pedido (id_cliente, dt_venda) VALUES (@id_cliente, @dt_venda)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", dto.IdCliente));
            parms.Add(new MySqlParameter("dt_venda", dto.Data));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_pedido WHERE id_pedido = @id_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }



        public List<PedidoConsultarView> Consultar(string cliente)
        {
            string script = @"SELECT * FROM vw_pedido_consultar WHERE nm_cliente like @nm_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", "%" + cliente + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoConsultarView> lista = new List<PedidoConsultarView>();
            while (reader.Read())
            {
                PedidoConsultarView dto = new PedidoConsultarView();
                dto.Id = reader.GetInt32("id_pedido");
                dto.Cliente = reader.GetString("nm_cliente");
                dto.QtdItens = reader.GetInt32("qtd_itens");
                dto.Data = reader.GetDateTime("dt_venda");
                dto.Total = reader.GetDecimal("vl_total");


                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }

    }
}
