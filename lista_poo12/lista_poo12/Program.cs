using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1;
            triangulo1 = new Triangulo();

            triangulo1.setA(entrarDouble("Digite o valor de A: "));
            triangulo1.setB(entrarDouble("Digite o valor de B: "));
            triangulo1.setC(entrarDouble("Digite o valor de C: "));

            triangulo1.calcular();

            if (triangulo1.getRetangulo())
            {
                Console.WriteLine("Os valores {0}, {1} e {2} formam um triângulo retângulo",
                    triangulo1.getA(),
                    triangulo1.getB(),
                    triangulo1.getC());
            }
            else
            {
                Console.WriteLine("Os valores {0}, {1} e {2} não formam um triângulo retângulo",
                    triangulo1.getA(),
                    triangulo1.getB(),
                    triangulo1.getC());
            }
        }



        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}