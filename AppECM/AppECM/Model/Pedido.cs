using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppECM.Model
{
    [Table("Pedido")]
    public class Pedido
    {
        [PrimaryKey, AutoIncrement]
        public int idPedido { get; set; }
        public int idUsuario { get; set; }

        public int idProduto { get; set; }
        public int quantidade { get; set; }
     

        public string pedidoformatado { get; set; }
        public string login { get; set; }

        public Pedido get()
        {
            return new DataBase.PedidoDataBase().GetLast();
        }
        public List<Pedido> GetAllbyUser(int idUsuario)
        {
            return new DataBase.PedidoDataBase().GetAllbyUser(idUsuario);
        }
        public void save(Pedido pedido)
        {
            if (pedido != null)
            {
                new DataBase.PedidoDataBase().Save(pedido);
            }
        }
        public void update(Pedido pedido)
        {
            if (pedido != null)
            {
                new DataBase.PedidoDataBase().UpdateUser(pedido);
            }
        }
      

    }
}
