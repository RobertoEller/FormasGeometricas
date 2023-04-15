using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4.Formas
{
    internal sealed class Octagono : Forma
    {
        public double Apotema { get; set; }
        public double Lado { get; set; }
        public Octagono(double l, double a)
        {
            this.Lado = l;
            this.Apotema = a;
        }

        public override double CalcularArea()
        {
            return this.Area = 2 * (1 + Math.Sqrt(2)) * Lado * Apotema;
        }

        public override double CalcularPerimetro()
        {
            return this.Perimetro = Lado * 8;
        }

        public override void Mostrar()
        {
            
        }
    }
}
