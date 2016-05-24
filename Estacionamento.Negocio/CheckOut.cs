using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Negocio
{
    public class CheckOut : Icomand
    {
        DateTime _dataCheckOut = DateTime.Now;
        Carro _car;

        public DateTime dataCheckOut { get { return _dataCheckOut; } }
        public Carro car { get { return _car; } }


        public CheckOut(string placa)
        {
            _car.placa = placa;
        }
        public void Run(){
            Estacionamento.Remover(_car);
        }
    }
}
