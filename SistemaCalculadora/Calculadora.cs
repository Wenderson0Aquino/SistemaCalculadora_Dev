using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCalculadora
{
    internal class Calculadora
    {
        private double PrimeiroNumero { get; set; }
        private double SegundoNumero { get; set; }

        public Calculadora() { }
      
        public double Somar(double primeiroNumero, double segundoNumero)
        {
            double resultado = primeiroNumero + segundoNumero;
            return resultado;
        }
        public double Subtrair(double primeiroNumero, double segundoNumero)
        {
            double resultado = primeiroNumero - segundoNumero;
            return resultado;
        }
        public double Multiplicar(double primeiroNumero, double segundoNumero)
        {
            double resultado = primeiroNumero * segundoNumero;
            return resultado;
        }
        public double Dividir(double primeiroNumero, double segundoNumero)
        {
            double resultado = primeiroNumero / segundoNumero;
            return resultado;
        }
        public double CalcularPotencia(double primeiroNumero, double segundoNumero)
        {
            double resultado = Math.Pow(primeiroNumero, segundoNumero);
            return resultado;
        }
        ~Calculadora() { }
    }
}
