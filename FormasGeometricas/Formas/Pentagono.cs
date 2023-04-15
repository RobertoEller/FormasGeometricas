using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4.Formas
{
    internal sealed class Pentagono : Forma
    {
        public double Apotema { get; set; }
        public double Lado { get; set; }

        public Pentagono(double l, double a)
        {
            this.Apotema = a;
            this.Lado = l;
        }

        public override double CalcularArea()
        {
            return this.Area = (5 * Apotema * Lado) / 2;
        }

        public override double CalcularPerimetro()
        {
           return this.Perimetro = Lado * 5;
        }

        public override void Mostrar()
        {
           
        }
    }
}
