using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4.Formas
{
    internal sealed class Circulo : Forma
    {
        public double Raio { get; set; }
        public Circulo(double r)
        {
            this.Raio = r;
        }
        public override double CalcularArea()
        {
            return this.Area = Math.Pow(Raio, 2) * Math.PI;
        }

        public override double CalcularPerimetro()
        {
            return this.Perimetro = 2 * Raio * Math.PI;
        }
        public override void Mostrar()
        {

        }
    }
}
