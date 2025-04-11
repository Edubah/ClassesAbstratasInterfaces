using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasInterfaces.Models
{
    public abstract class Conta //Ser uma classe abstract faz ela ser uma classe com o propósito unico de ser apenas herdada
    {
        protected decimal saldo; // O saldo é protegido para que não possa ser acessado diretamente fora da classe

        public abstract void Creditar(decimal valor); // Método abstrato para creditar um valor na conta, deve ser implementado nas classes filhas
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é: {saldo:C}"); // O :C formata o valor como moeda
        }
    }
}