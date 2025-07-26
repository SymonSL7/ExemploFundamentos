using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Resto(int x, int y)
        {
            Console.WriteLine($"{x} % {y} = {x % y}");
        }

        public void Potencia(int x, int y)
        {
            double resultado = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {resultado}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz de quadrade de {x} = {raiz}");
        }

        public void Tabuada(double x, string operador, int y)
        {
            for (int i = 1; i <= y; i++)
            {
                if (operador.Equals("+"))
                {
                    Console.WriteLine($"{x} {operador} {i} = {x + i}");
                }
                else if (operador.Equals("-"))
                {
                    Console.WriteLine($"{x} {operador} {i} = {x - i}");
                }
                else if (operador.Equals("*"))
                {
                    Console.WriteLine($"{x} {operador} {i} = {x * i}");
                }
                else if (operador.Equals("/"))
                {
                    Console.WriteLine($"{x} {operador} {i} = {x / i}");
                }
                else
                {
                    Console.WriteLine("Operador Invalido");
                }                

            }
        }
        
    }
}