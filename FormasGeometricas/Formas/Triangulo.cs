using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4.Formas
{
    internal sealed class Triangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Triangulo (double b, double h)
        {
            this.Base = b;
            this.Altura = h;
        }
        public override double CalcularArea()
        {
           return this.Area = (Base * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return this.Perimetro = Base * 3;
        }

        public override void Mostrar()
        {
            
        }
    }
}
