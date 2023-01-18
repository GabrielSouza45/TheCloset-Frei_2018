using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Registrar_usuario
{
     class UsuarioBusiness
    {
        public int Salvar(UsuarioDTO dto)
        { 

            UsuarioDTO cliente = this.ConsultarPorCpf(dto.CPF);
            if (cliente != null)
            {
                
                throw new ArgumentException("CPF já cadastrado no sistema.");
            }
            UsuarioDTO neww = this.ConsultarPorEmail(dto.Login);
            if (neww != null)
            {
                throw new ArgumentException("E-mail já cadastrado no sistema.");
            }
            UsuarioDTO newew = this.ConsultarPorTelefone(dto.Telefone);
            if (newew != null)
            {
                throw new ArgumentException("Telefone já cadastrado no sistema.");
            }
            UsuarioDTO newwe = this.ConsultarPorCelular(dto.Celular);
            if (newwe != null)
            {
                throw new ArgumentException("Celular já cadastrado no sistema.");
            }

            UsuarioDatabase db = new UsuarioDatabase();
            return db.Salvar(dto);
        }


        public UsuarioDTO ConsultarPorCpf(string CPF)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.ConsultarPorCpf(CPF);
        }
        public UsuarioDTO ConsultarPorEmail(string Login)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.ConsultarPorEmail(Login);
        }
        public UsuarioDTO ConsultarPorTelefone(string Telefone)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.ConsultarPorTelefone(Telefone);
        }
        public UsuarioDTO ConsultarPorCelular(string Celular)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.ConsultarPorCelular(Celular);
        }

        public List<UsuarioDTO> Listar()
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.Listar();
        }

        public List<UsuarioDTO> Consultar(string usuario)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.Consultar(usuario);
        }





    }
}
