using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Negocio
{
    public static class Estacionamento
    {       
        private static IDictionary<Carro, DateTime> _estacionamento = new Dictionary<Carro, DateTime>();

        /// <summary>
        /// Retorna todos os carros no estacionamento
        /// </summary>
        /// 
        //public static IDictionary<Carro, DateTime> estacionamento { get { return _estacionamento; } set {_estacionamento = estacionamento ;} }
        
        public static IDictionary<Carro, DateTime> ObterTodosCarros()
        {
            return _estacionamento;
        }
        public static void Adiciona(Carro car, DateTime entrada)
        {
            _estacionamento.Add(car,  entrada);
        }
        public static void Remover(Carro car)
        {
            _estacionamento.Remove(car);
        }

    }
}
