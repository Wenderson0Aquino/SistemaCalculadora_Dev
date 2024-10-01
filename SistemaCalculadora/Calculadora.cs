using System;

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
        public static string Baskara(double a, double b, double c)
        {
            double delta = b * b - (4 * a * c);

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                return "X¹: " + x1.ToString() + "\nX²: " + x2.ToString();
            }
            else
            {
                if (delta == 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    return "X¹ e X²: " + x1.ToString();
                }
                else
                {
                    return "Não existem raizer reais!";
                }
            }
        }
        ~Calculadora() { }
    }
}
