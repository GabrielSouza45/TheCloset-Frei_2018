using Loja_VesteBem.BASE;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Registrar_usuario
{
    class UsuarioDatabase
    {
        public int Salvar(UsuarioDTO dto)
        {
            string script = @"INSERT INTO tb_cliente (nm_cliente, ds_cpf, ds_telefone, ds_celular, ds_login, ds_senha, bt_adm) 
                                   VALUES (@nm_cliente, @ds_cpf, @ds_telefone, @ds_celular, @ds_login, @ds_senha, @bt_adm)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", dto.Nome));
            parms.Add(new MySqlParameter("ds_cpf", dto.CPF));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_celular", dto.Celular));
            parms.Add(new MySqlParameter("ds_login", dto.Login));
            parms.Add(new MySqlParameter("ds_senha", dto.Senha));
            parms.Add(new MySqlParameter("bt_adm", dto.Adiministrador));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void Alterar(UsuarioDTO dto)
        {
            string script = @"UPDATE tb_cliente 
                                 SET nm_cliente = @nm_cliente
                                     ds_cpf = @ds_cpf
                                     ds_telefone = @ds_telefone
                                     ds_celular = @ds_celular
                                     ds_login = @ds_login
                                     ds_senha = @ds_senha

                               WHERE id_produto = @id_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", dto.IdUsuario));
            parms.Add(new MySqlParameter("nm_cliente", dto.Nome));
            parms.Add(new MySqlParameter("ds_cpf", dto.CPF));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_celular", dto.Celular));
            parms.Add(new MySqlParameter("ds_login", dto.Login));
            parms.Add(new MySqlParameter("ds_senha", dto.Senha));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_cliente WHERE id_cliente = @id_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<UsuarioDTO> Consultar(string usuario)
        {
            string script = @"SELECT * FROM tb_cliente WHERE nm_cliente like @nm_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", usuario + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            while (reader.Read())
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.IdUsuario = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.CPF = reader.GetString("ds_cpf");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Celular = reader.GetString("ds_celular");
                dto.Login = reader.GetString("ds_login");
                dto.Senha = reader.GetString("ds_senha");
                dto.Adiministrador= reader.GetBoolean("bt_adm");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }

        public List<UsuarioDTO> Listar()
        {
            string script = @"SELECT * FROM tb_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            while (reader.Read())
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.IdUsuario = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.CPF = reader.GetString("ds_cpf");
                dto.Celular = reader.GetString("ds_celular");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Login = reader.GetString("ds_login");
                dto.Senha = reader.GetString("ds_senha");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
        public List<UsuarioDTO> consultar(string Nome)
        {
            string script =
            @"SELECT * FROM tb_cliente WHERE nm_cliente LIKE @nm_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", "%" + Nome + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<UsuarioDTO> Usuario = new List<UsuarioDTO>();
            while (reader.Read())
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.IdUsuario = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.CPF = reader.GetString("ds_cpf");
                dto.Celular = reader.GetString("ds_celular");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Login = reader.GetString("ds_login");
                dto.Senha = reader.GetString("ds_senha");

                Usuario.Add(dto);
            }
            reader.Close();
            return Usuario;
        }
        public UsuarioDTO ConsultarPorCpf(string cpf)
        {
            string script = @"SELECT * FROM tb_cliente WHERE ds_cpf = @ds_cpf";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_cpf", cpf));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            UsuarioDTO dto = null;
            if (reader.Read())
            {
                dto = new UsuarioDTO();

                dto.IdUsuario = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.CPF = reader.GetString("ds_cpf");
            }
            reader.Close();

            return dto;
        }
        public UsuarioDTO ConsultarPorEmail(string email)
        {
            string script = @"SELECT * FROM tb_cliente WHERE ds_login = @ds_login";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_login", email));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            UsuarioDTO dto = null;
            if (reader.Read())
            {
                dto = new UsuarioDTO();

                dto.IdUsuario = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.Login = reader.GetString("ds_login");
            }
            reader.Close();

            return dto;
        }
        public UsuarioDTO ConsultarPorTelefone(string Telefone)
        {
            string script = @"SELECT * FROM tb_cliente WHERE ds_Telefone = @ds_Telefone";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_telefone", Telefone));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            UsuarioDTO dto = null;
            if (reader.Read())
            {
                dto = new UsuarioDTO();

                dto.IdUsuario = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.Telefone = reader.GetString("ds_telefone");
            }
            reader.Close();

            return dto;
        }
        public UsuarioDTO ConsultarPorCelular(string Celular)
        {
            string script = @"SELECT * FROM tb_cliente WHERE ds_celular = @ds_celular";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_celular", Celular));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            UsuarioDTO dto = null;
            if (reader.Read())
            {
                dto = new UsuarioDTO();

                dto.IdUsuario = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.Telefone = reader.GetString("ds_celular");
            }
            reader.Close();

            return dto;
        }
    }
}
