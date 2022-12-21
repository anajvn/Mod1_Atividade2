using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Atividade2
{
    internal class Pergunta4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A estratégia deve enviar ao mercado: " + funcaoRetornaQuantitadePOV(0.1m, 90)); //10
            Console.WriteLine("A estratégia deve enviar ao mercado: " + funcaoRetornaQuantitadePOV(0.1m, 100)); //11
            Console.WriteLine("A estratégia deve enviar ao mercado: " + funcaoRetornaQuantitadePOV(0.2m, 70)); //17
            Console.WriteLine("A estratégia deve enviar ao mercado: " + funcaoRetornaQuantitadePOV(0.64m, 120));
        }

        public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
        {
            return Decimal.ToInt32(Math.Truncate(porcentagem * totalNegociado / (1 - porcentagem)));
        }
    }
}

