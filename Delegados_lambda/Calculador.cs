using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_lambda
{
    public class Calculador
    {
        private double _numero;

        public Calculador(double numero)
        {
            _numero = numero;
        }

        public double multiplicar (double num)
        {
            return num * _numero;
        }

        public double sumar ( double num)
        {
            return num + _numero;
        }
    }
}
