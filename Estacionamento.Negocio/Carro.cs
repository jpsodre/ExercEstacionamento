﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Negocio
{
    public class Carro
    {        
        public string placa { get  ; set; }

        public Carro(string plate)
        {
            placa = plate;
        }

    }
}
