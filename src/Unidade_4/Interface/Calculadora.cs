using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Unidade_4.Interface;

namespace src.Unidade_4.Interface
{
    public class Calculadora : ICalcuadora
    {
        public int Somar (int num1,int num 2)
        {
            return num1 + num2;
        }
        public int Substrair (int num1,int num 2)
        {
            return num1 - num2;
        }
        public int Multiplicar (int num1,int num 2)
        {
            return num1 * num2;
        }
        public int Dividir (int num1,int num 2)
        {
            return num1 /  num2;
        }
    }
}