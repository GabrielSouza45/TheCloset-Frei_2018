using Loja_VesteBem.BASE;
using Loja_VesteBem.DB.Registrar_usuario;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Fornecedores
{
    class LoginDatabase
    {
        public UsuarioDTO Logar(string login, string senha)
        {
            string script = @"SELECT * FROM tb_cliente WHERE ds_login = @ds_login AND ds_senha = @ds_senha";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_login", login));
            parms.Add(new MySqlParameter("ds_senha", senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            UsuarioDTO dto = null;

            if (reader.Read())
            {
                dto = new UsuarioDTO();
                dto.IdUsuario = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.CPF = reader.GetString("ds_cpf");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Celular = reader.GetString("ds_celular");
                dto.Login = reader.GetString("ds_login");
                dto.Senha = reader.GetString("ds_senha");
                dto.Adiministrador = reader.GetBoolean("bt_adm");
            }
            reader.Close();

            return dto;
        }
    }
}
