using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Negocio
{
    /// <summary>
    /// Classe com as operações de um estacionamento.
    /// </summary>
    public sealed class Operacoes
    {
        private const double VALOR_MIN = 5;
        private const int VAGAS_TOTAIS = 15;


        /// <summary>
        /// Registra a entrada de um carro no estacionamento.
        /// </summary>
        public static void Checkin(string placa)
        {
            CheckIn check = new CheckIn(placa);

            if (String.Equals(check.car.placa, string.Empty))
                throw new Exception(String.Format("Placa inválida.", placa));

            if (Estacionamento.ObterTodosCarros().Count == VAGAS_TOTAIS)
                throw new Exception("Estacionamento cheio!");

            foreach (Carro c in Estacionamento.ObterTodosCarros().Keys)
            {
                if (c.placa.Equals(check.car.placa))
                {
                    throw new Exception(String.Format("Carro placa '{0} já existe!", placa));                    
                }
            }
            // if (Estacionamento.ObterTodosCarros().ContainsKey(check.car))
            //throw new Exception(String.Format("Carro placa '{0} já existe!", placa));

            Estacionamento.Adiciona(check.car, check.dataCheckIn);            
        }

        /// <summary>
        /// Registra a saída de um carro do estacionamento.
        /// </summary>
        public static double Checkout(string placa)
        {
            CheckOut check = new CheckOut(placa);

            if (String.Equals(check.car.placa, string.Empty))
                throw new Exception(String.Format("Placa inválida.", placa));

            if (!Estacionamento.ObterTodosCarros().ContainsKey(check.car))
                throw new Exception(String.Format("Carro placa '{0}' NÃO existe!", placa));

            var valor = CalculaEstacionamento(Estacionamento.ObterTodosCarros()[check.car], check.dataCheckOut);
            Estacionamento.Remover(check.car);
            
            return valor;
        }

        /// <summary>
        /// Calcula o valor com base no tempo de permanência
        /// </summary>
        private static double CalculaEstacionamento(DateTime entrada, DateTime saida)
        {
            var permanencia = saida.Subtract(entrada);
            return Math.Round((permanencia.TotalMinutes / VALOR_MIN), 2);
        }
    }
}
