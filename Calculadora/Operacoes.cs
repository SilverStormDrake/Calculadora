using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Operacoes
    {
        public float Soma(float a, float b) 
        {
            return a + b;
        }

        public float Subtracao(float a, float b) 
        {
            return a - b;
        }

        public float Multiplicacao(float a, float b) 
        {
            return a * b;
        }

        public float Divisao(float a, float b)
        {
            return a / b;
        }

        public double RaizQuadrada(double a) 
        {
            return Math.Sqrt(a);
        }

        public double Potencia(float a, int b)
        {
            float pot = 1;
            for (int i = 1; b >= i; i++) 
            {
                pot = pot * a;
            }

            return pot;
        }

        public string RaizdeFuncao(double a , double b , double c) 
        {
            double Delta = b * b - (4 * a * c);
            double check1 = (-b + Math.Sqrt(Delta))/2*a;
            double check2 = (-b - Math.Sqrt(Delta))/2*a;

            if(check1 == check2) 
            {
                return "" + check1;
            }
            else 
            {
                return check1 + " " + check2;
            }
            
        }
    }
}
