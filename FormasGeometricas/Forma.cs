using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    public abstract class Forma
    {
        public double Area{ get; set; }
        public double Perimetro { get; set; }
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public abstract void Mostrar();
    }
}
