using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo4
{
    internal class Triangulo
    {
        // Atributos
        private double base_;
        private double altura;
        private double area;

        // Métodos construtores
        public Triangulo()
        {
            this.base_ = 0;
            this.altura = 0;
            this.area = 0;
        }
        public Triangulo(double base_, double altura)
        {
            this.base_ = base_;
            this.altura = altura;
            this.area = 0;
        }

        // Métodos de interface (set/get)
        public void setBase(double base_)
        {
            this.base_ = base_;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public double getBase()
        {
            return this.base_;
        }
        public double getAltura()
        {
            return this.altura;
        }
        public double getArea()
        {
            return this.area;
        }
        // Método funcional
        public void calcular()
        {
            this.area = (this.base_ * this.altura) / 2;
        }
    }
}