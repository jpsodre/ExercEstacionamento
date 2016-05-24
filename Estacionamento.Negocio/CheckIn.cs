using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Negocio
{
    public class CheckIn : Icomand
    {
        DateTime _dataCheckIn = DateTime.Now;
        Carro _car;

        public DateTime dataCheckIn { get { return _dataCheckIn; } }
        public Carro car { get { return _car; } }

        public CheckIn(string placa)
        {
            _car = new Carro(placa);
        }

        public void Run()
        {
            Estacionamento.Adiciona(_car,DateTime.Now);
        }
    }
}
