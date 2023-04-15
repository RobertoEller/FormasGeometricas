using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4.Formas
{
    internal sealed class Quadrado : Forma
    {
        public double Lado { get; set; }
        public Quadrado(double l)
        {
            this.Lado = l;
        }
        public override double CalcularArea()
        {
            return this.Area = Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return this.Perimetro = Lado * 4;
        }

        public override void Mostrar()
        {

        }
    }
}
