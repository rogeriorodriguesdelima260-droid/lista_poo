using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo12
{
    internal class Triangulo
    {
        // Atributos
        private double a;
        private double b;
        private double c;
        private bool retangulo;

        // Métodos construtores
        public Triangulo()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
            this.retangulo = false;
        }
        public Triangulo(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.retangulo = false;
        }

        // Métodos de interface (set/get)
        public void setA(double a)
        {
            this.a = a;
        }
        public void setB(double b)
        {
            this.b = b;
        }
        public void setC(double c)
        {
            this.c = c;
        }
        public double getA()
        {
            return this.a;
        }
        public double getB()
        {
            return this.b;
        }
        public double getC()
        {
            return this.c;
        }
        public bool getRetangulo()
        {
            return this.retangulo;
        }
        // Método funcional
        public void calcular()
        {
            double maior;
            double cateto1;
            double cateto2;

            if (this.a >= this.b && this.a >= this.c)
            {
                maior = this.a;
                cateto1 = this.b;
                cateto2 = this.c;
            }
            else if (this.b >= this.a && this.b >= this.c)
            {
                maior = this.b;
                cateto1 = this.a;
                cateto2 = this.c;
            }
            else
            {
                maior = this.c;
                cateto1 = this.a;
                cateto2 = this.b;
            }

            if ((maior * maior) == (cateto1 * cateto1) + (cateto2 * cateto2))
            {
                this.retangulo = true;
            }
            else
            {
                this.retangulo = false;
            }
        }
    }
}