using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratasInterfaces.Interface
{
    public interface ICalculadora
    {
        //Métodos sem corpos são obrigatórios numa Interface
        int Somar (int n1, int n2);
        int Subtrair (int n1, int n2);
        int Multiplicar (int n1, int n2);
        
        //Métodos com corpos são opcionais ai serem implementados
        int Dividir (int n1, int n2)
        {
            return n1 / n2;
        }
    }
}