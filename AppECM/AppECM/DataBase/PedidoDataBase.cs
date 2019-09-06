using System.Collections.Generic;
using System.Linq;
using AppECM.Contratos;
using AppECM.Model;
using SQLite;
using Xamarin.Forms;


namespace AppECM.DataBase
{
    public class PedidoDataBase
    {
        private SQLiteConnection _dataBase;
        public PedidoDataBase()
        {
            _dataBase = DependencyService.Get<IDataBase>().GetConnection();
            _dataBase.CreateTable<Pedido>();
        }
        public List<Pedido> GetAllbyUser(int idUduario)
        {
            return _dataBase.Table<Pedido>().Where(x=>x.idUsuario == idUduario).ToList();
        }
        public Pedido GetLast()
        {
            return _dataBase.Table<Pedido>().LastOrDefault();
        }
        public int Save(Pedido user)
        {
            return _dataBase.Insert(user);
        }
        public int UpdateUser(Pedido user)
        {
            return _dataBase.Update(user);
        }
        public int Delete(Pedido user)
        {
            return _dataBase.Delete(user);
        }
        public int DeleteAll()
        {
            return _dataBase.DeleteAll<Pedido>();
        }
    }
}

