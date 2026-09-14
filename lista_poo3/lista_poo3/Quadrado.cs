using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo3
{
    internal class Quadrado
    {
        // Atributos
        private double diagonal;
        private double area;

        // Métodos construtores
        public Quadrado()
        {
            this.diagonal = 0;
            this.area = 0;
        }
        public Quadrado(double diagonal)
        {
            this.diagonal = diagonal;
            this.area = 0;
        }

        // Métodos de interface (set/get)
        public void setDiagonal(double diagonal)
        {
            this.diagonal = diagonal;
        }
        public double getDiagonal()
        {
            return this.diagonal;
        }
        public double getArea()
        {
            return this.area;
        }
        // Método funcional
        public void calcular()
        {
            this.area = (this.diagonal * this.diagonal) / 2;
        }
    }
}