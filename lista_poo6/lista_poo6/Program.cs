using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorDolar conversor1;
            conversor1 = new ConversorDolar();

            conversor1.setCotacao(entrarDouble("Digite a cotação do dólar: "));
            conversor1.setQuantidadeDolares(entrarDouble("Digite a quantidade de dólares: "));

            conversor1.calcular();
            Console.WriteLine("{0} dólares equivalem a R$ {1}",
                conversor1.getQuantidadeDolares(),
                conversor1.getValorReais());
        }



        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}