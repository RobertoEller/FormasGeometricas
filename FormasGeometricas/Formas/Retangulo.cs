using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4.Formas
{
    internal sealed class Retangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Retangulo(double b, double h)
        {
            this.Base = b;
            this.Altura = h;
        }
        public override double CalcularArea()
        {
            return this.Area = Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return this.Perimetro = 2 * (Base + Altura);
        }

        public override void Mostrar()
        {
            
        }
    }
}
