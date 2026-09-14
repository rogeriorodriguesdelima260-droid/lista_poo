using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo7
{
    internal class Comparador
    {
        // Atributos
        private double valor1;
        private double valor2;
        private double maior;

        // Métodos construtores
        public Comparador()
        {
            this.valor1 = 0;
            this.valor2 = 0;
            this.maior = 0;
        }
        public Comparador(double valor1, double valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
            this.maior = 0;
        }

        // Métodos de interface (set/get)
        public void setValor1(double valor1)
        {
            this.valor1 = valor1;
        }
        public void setValor2(double valor2)
        {
            this.valor2 = valor2;
        }
        public double getValor1()
        {
            return this.valor1;
        }
        public double getValor2()
        {
            return this.valor2;
        }
        public double getMaior()
        {
            return this.maior;
        }
        // Método funcional
        public void calcular()
        {
            if (this.valor1 > this.valor2)
            {
                this.maior = this.valor1;
            }
            else
            {
                this.maior = this.valor2;
            }
        }
    }
}