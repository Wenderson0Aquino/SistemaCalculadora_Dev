﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();   
            Console.WriteLine(calculadora.CalcularPotencia(2, 2));
            Console.ReadKey();
        }
    }
}
