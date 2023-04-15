using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4.Formas
{
    internal sealed class Hexagono : Forma
    {
        public double Lado { get; set; }
        public double Apotema { get; set; }
        public Hexagono(double l, double a)
        {
            this.Lado = l;
            Apotema = a;
        }

        public override double CalcularArea()
        {
            return this.Area = 3 * Lado * Apotema;
        }

        public override double CalcularPerimetro()
        {
            return this.Perimetro = Lado * 6;
        }
        public override void Mostrar()
        {

        }
    }
}
