using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassesAbstratasInterfaces.Interface;

namespace ClassesAbstratasInterfaces.Models
{
    public class Calculadora : ICalculadora
    {
        public  int Somar (int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair (int n1, int n2)
        {
            return n1 - n2;
        }

        public int Dividir (int n1, int n2)
        {
            return n1 / n2;
        }

        public int Multiplicar (int n1, int n2)
        {
            return n1 * n2;
        }
    }
}