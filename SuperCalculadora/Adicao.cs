﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    public class Adicao : IOperacao
    {
        public double Calcular(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}