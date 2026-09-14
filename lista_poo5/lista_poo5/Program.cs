using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorMilhas conversor1;
            conversor1 = new ConversorMilhas();

            conversor1.setMilhas(entrarDouble("Digite o valor em milhas marítimas: "));

            conversor1.calcular();
            Console.WriteLine("{0} milhas marítimas equivalem a {1} quilômetros",
                conversor1.getMilhas(),
                conversor1.getQuilometros());
        }



        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}