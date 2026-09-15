using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1;
            retangulo1 = new Retangulo();

            retangulo1.setBase(entrarDouble("Digite a base do retângulo: "));
            retangulo1.setAltura(entrarDouble("Digite a altura do retângulo: "));

            retangulo1.calcular();

            Console.WriteLine("A área do retângulo de base {0} e altura {1} é {2}",
                retangulo1.getBase(),
                retangulo1.getAltura(),
                retangulo1.getArea());

            if (retangulo1.getArea() > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");
            }
        }



        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}