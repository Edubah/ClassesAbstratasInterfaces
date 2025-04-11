using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasInterfaces.Models
{
    public class Aluno : Pessoa
    {
        public Aluno() // Construtor padrão, não é obrigatório, mas é uma boa prática ter um construtor padrão
        {
            
        }
        public Aluno(string nome) : base(nome) // Construtor que chama o construtor da classe base (Pessoa) e passa o nome
        {
            
        }
        public double Nota { get; set; }
        public override voiud Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e minha nota é {Nota}.");
        }
    }
}