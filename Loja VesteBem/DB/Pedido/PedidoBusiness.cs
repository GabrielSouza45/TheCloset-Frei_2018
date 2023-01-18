using Loja_VesteBem.DB.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_VesteBem.DB.Fornecedores
{
    public class PedidoBusiness
    {
        public int Salvar(PedidoDTO pedido, List<ProdutoDTO> produtos)
        {
            PedidoDatabase pedidoDatabase = new PedidoDatabase();
            int idPedido = pedidoDatabase.Salvar(pedido);

            PedidoItemBusiness itemBusiness = new PedidoItemBusiness();
            foreach (ProdutoDTO item in produtos)
            {
                PedidoItemDTO dto = new PedidoItemDTO();
                dto.IdPedido = idPedido;
                dto.IdProduto = item.Id;

                itemBusiness.Salvar(dto);
            }

            return idPedido;
        }

        public void Remover(int id)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            db.Remover(id);
        }

        //public void Remover(int Id)
        //{
        //    PedidoItemBusiness business = new PedidoItemBusiness();
        //    List<PedidoItemDTO> itens = business.ConsultarPorPedido(Id);

        //    foreach (PedidoItemDTO item in itens)
        //    {
        //        business.Remover(item.Id);
        //    }

        //    PedidoDatabase pedidoDatabase = new PedidoDatabase();
        //    pedidoDatabase.Remover(Id);
        //}

        public List<PedidoConsultarView> Consultar(string cliente)
        {
            PedidoDatabase bd = new PedidoDatabase();
            return bd.Consultar(cliente);
        }

    }
}
