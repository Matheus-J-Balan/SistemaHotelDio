using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() 
        {


        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            bool verificaCapacidade = Suite.Capacidade >= hospedes.Count;

            if (verificaCapacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
               throw new Exception("A capacidade da Suite é menor que a quantoiidade de hospedes");
            }
        }


        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor -= (valor * 0.10M);
            }

            return valor;
        }
    }
}
