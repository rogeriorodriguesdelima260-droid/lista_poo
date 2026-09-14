using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado1;
            quadrado1 = new Quadrado();

            quadrado1.setDiagonal(entrarDouble("Digite a diagonal do quadrado: "));

            quadrado1.calcular();
            Console.WriteLine("A área do quadrado de diagonal {0} é {1}",
                quadrado1.getDiagonal(),
                quadrado1.getArea());
        }



        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}