using AppECM.Services.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AppECM.Model
{
    public class Produto : BaseService
    {
        private IList<Produto> _produto;
        public Produto()
        {
            _produto = new List<Produto>();
        }
        public int id { get; set; }
        public string descricao { get; set; }
        public int qtdDisponivel { get; set; }
        public double PrecoUnitario { get; set; }
        public string PrecoUnitarioFormatado { get; set; }
    }
    public class Value
    {
        private IList<Value> _value;
        public Value()
        {
            _value = new List<Value>();
        }
        public int id { get; set; }
        public string simbolo { get; set; }
        public string nomeFormatado { get; set; }
        public string tipoMoeda { get; set; }
    }

    public class Moedas
    {

        public List<Value> value { get; set; }
    }
}
