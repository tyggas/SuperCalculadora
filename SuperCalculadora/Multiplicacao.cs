using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    public class Multiplicacao : IOperacao
    {
        public double Calcular(double numn1, double num2)
        {
            return numn1 * num2;
            
        }
    }
}
