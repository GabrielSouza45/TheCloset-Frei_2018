using Loja_VesteBem.BASE;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Entregas
{
    class EntregasDatabase
    {
        public List<EntregasConsultarView> Consultar(string entregas)
        {
            string script = @"SELECT * FROM VW_ENTREGAS_CONSULTAR WHERE nm_cliente like @nm_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", "%" + entregas + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EntregasConsultarView> lista = new List<EntregasConsultarView>();
            while (reader.Read())
            {
                EntregasConsultarView dto = new EntregasConsultarView();
                dto.Id = reader.GetInt32("id_entrega");
                dto.Cliente = reader.GetString("nm_cliente");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Cidade = reader.GetString("nm_cidade");
                dto.Rua = reader.GetString("ds_rua");
                dto.CEP = reader.GetString("ds_cep");
                dto.NumeroCasa = reader.GetInt32("ds_numerocasa");
                dto.IdPedido = reader.GetInt32("id_pedido");


                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
        public List<EntregasConsultarView> Listar()
        {
            string script =
            @"SELECT * FROM tb_entrega";
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);
            List<EntregasConsultarView> entregas = new List<EntregasConsultarView>();
            while (reader.Read())
            {
                EntregasConsultarView dto = new EntregasConsultarView();
                dto.Id = reader.GetInt32("id_entrega");
                dto.Cliente = reader.GetString("nm_cliente");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Cidade = reader.GetString("nm_cidade");
                dto.Rua = reader.GetString("ds_rua");
                dto.CEP = reader.GetString("ds_cep");
                dto.NumeroCasa = reader.GetInt32("ds_numerocasa");
                dto.IdPedido = reader.GetInt32("id_pedido");

                entregas.Add(dto);
            }
            reader.Close();
            return entregas;
        }
    }
}
