using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculos.Models
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

        public void Multiplicacao(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Divisao(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x,int y)
        {
            double resPotencia = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {resPotencia} ");
        }

        public void Sen(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine(Math.Round(seno,2));
        }
        public void Cos(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Sin(radiano);
            Console.WriteLine(Math.Round(coseno,4));
        }
        public void Tang(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Sin(radiano);
            Console.WriteLine(Math.Round(tangente,3));
        }

        public void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz);
        }
    }
}