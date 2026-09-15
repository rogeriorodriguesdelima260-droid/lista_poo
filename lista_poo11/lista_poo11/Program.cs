using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1;
            triangulo1 = new Triangulo();

            triangulo1.setLado1(entrarDouble("Digite o 1º lado: "));
            triangulo1.setLado2(entrarDouble("Digite o 2º lado: "));
            triangulo1.setLado3(entrarDouble("Digite o 3º lado: "));

            triangulo1.calcular();

            if (triangulo1.getFormaTriangulo())
            {
                Console.WriteLine("Os lados formam um triângulo {0}", triangulo1.getClassificacao());
            }
            else
            {
                Console.WriteLine("Os lados não formam um triângulo");
            }
        }



        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}