﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    public interface IOperacao
    {
        double Calcular(double num1, double num2);
    }
}