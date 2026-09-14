using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1;
            triangulo1 = new Triangulo();

            triangulo1.setBase(entrarDouble("Digite a base do triângulo: "));
            triangulo1.setAltura(entrarDouble("Digite a altura do triângulo: "));

            triangulo1.calcular();
            Console.WriteLine("A área do triângulo de base {0} e altura {1} é {2}",
                triangulo1.getBase(),
                triangulo1.getAltura(),
                triangulo1.getArea());
        }



        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}