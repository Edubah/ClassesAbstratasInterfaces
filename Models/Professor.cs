using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasInterfaces.Models
{
    public class Professor : Pessoa
    {
        public Professor() // Construtor padrão, não é obrigatório, mas é uma boa prática ter um construtor padrão
        {
            
        }
        public Professor(string nome) : base (nome) // Construtor que chama o construtor da classe base (Pessoa) e passa o nome
        {
            
        }
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário é {Salario:C}.");
        }
    }
}