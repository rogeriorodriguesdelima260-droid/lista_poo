using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparador comparador1;
            comparador1 = new Comparador();

            comparador1.setValor1(entrarDouble("Digite o 1º valor: "));
            comparador1.setValor2(entrarDouble("Digite o 2º valor: "));

            comparador1.calcular();
            Console.WriteLine("O maior valor entre {0} e {1} é {2}",
                comparador1.getValor1(),
                comparador1.getValor2(),
                comparador1.getMaior());
        }



        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}