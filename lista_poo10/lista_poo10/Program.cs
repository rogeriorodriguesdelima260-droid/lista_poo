using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1;
            pessoa1 = new Pessoa();

            pessoa1.setPeso(entrarDouble("Digite o peso (kg): "));
            pessoa1.setAltura(entrarDouble("Digite a altura (m): "));

            pessoa1.calcular();

            Console.WriteLine("Relação peso/altura² = {0}", pessoa1.getRelacao());
            Console.WriteLine(pessoa1.getMensagem());
        }



        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}