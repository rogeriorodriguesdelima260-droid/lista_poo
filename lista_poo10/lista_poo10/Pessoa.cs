using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo10
{
    internal class Pessoa
    {
        // Atributos
        private double peso;
        private double altura;
        private double relacao;
        private string mensagem;

        // Métodos construtores
        public Pessoa()
        {
            this.peso = 0;
            this.altura = 0;
            this.relacao = 0;
            this.mensagem = "";
        }
        public Pessoa(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
            this.relacao = 0;
            this.mensagem = "";
        }

        // Métodos de interface (set/get)
        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public double getPeso()
        {
            return this.peso;
        }
        public double getAltura()
        {
            return this.altura;
        }
        public double getRelacao()
        {
            return this.relacao;
        }
        public string getMensagem()
        {
            return this.mensagem;
        }
        // Método funcional
        public void calcular()
        {
            this.relacao = this.peso / (this.altura * this.altura);

            if (this.relacao < 20)
            {
                this.mensagem = "Abaixo do peso";
            }
            else if (this.relacao < 25)
            {
                this.mensagem = "Peso ideal";
            }
            else
            {
                this.mensagem = "Acima do peso";
            }
        }
    }
}