using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_poo6
{
    internal class ConversorDolar
    {
        // Atributos
        private double cotacao;
        private double quantidadeDolares;
        private double valorReais;

        // Métodos construtores
        public ConversorDolar()
        {
            this.cotacao = 0;
            this.quantidadeDolares = 0;
            this.valorReais = 0;
        }
        public ConversorDolar(double cotacao, double quantidadeDolares)
        {
            this.cotacao = cotacao;
            this.quantidadeDolares = quantidadeDolares;
            this.valorReais = 0;
        }

        // Métodos de interface (set/get)
        public void setCotacao(double cotacao)
        {
            this.cotacao = cotacao;
        }
        public void setQuantidadeDolares(double quantidadeDolares)
        {
            this.quantidadeDolares = quantidadeDolares;
        }
        public double getCotacao()
        {
            return this.cotacao;
        }
        public double getQuantidadeDolares()
        {
            return this.quantidadeDolares;
        }
        public double getValorReais()
        {
            return this.valorReais;
        }
        // Método funcional
        public void calcular()
        {
            this.valorReais = this.quantidadeDolares * this.cotacao;
        }
    }
}