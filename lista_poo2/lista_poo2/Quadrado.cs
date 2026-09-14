using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo2
{
    internal class Quadrado
    {
        // Atributos
        private double aresta;
        private double area;

        // Métodos construtores
        public Quadrado()
        {
            this.aresta = 0;
            this.area = 0;
        }
        public Quadrado(double aresta)
        {
            this.aresta = aresta;
            this.area = 0;
        }

        // Métodos de interface (set/get)
        public void setAresta(double aresta)
        {
            this.aresta = aresta;
        }
        public double getAresta()
        {
            return this.aresta;
        }
        public double getArea()
        {
            return this.area;
        }
        // Método funcional
        public void calcular()
        {
            this.area = this.aresta * this.aresta;
        }
    }
}