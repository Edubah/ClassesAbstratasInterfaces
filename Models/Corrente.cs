using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasInterfaces.Models
{
    public class Corrente : Conta
    {
        public override void Creditar (decimal valor) //Método abstrato, obrigatório ser implementado
        {
            saldo += valor; // Adiciona o valor ao saldo
        }
        
    }
}