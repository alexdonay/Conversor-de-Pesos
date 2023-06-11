using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_Pesos
{
    public class UnitConverter
    {
        public double Converte(double valor, string unidadeOrigem, string unidadeDestino)
        {
            double valorOrigem = ObterValorDaUnidade(unidadeOrigem);
            double valorDestino = ObterValorDaUnidade(unidadeDestino);

            return (valor / valorOrigem) * valorDestino;
        }

        private double ObterValorDaUnidade(string unidade)
        {
            switch (unidade)
            {
                case "km":
                    return 1000;
                case "hm":
                    return 100;
                case "dam":
                    return 10;
                case "m":
                    return 1;
                case "dm":
                    return 0.1;
                case "cm":
                    return 0.01;
                case "mm":
                    return 0.001;
                default:
                    throw new ArgumentException("Unidade de medida inválida.");
            }
        }
    }

}    