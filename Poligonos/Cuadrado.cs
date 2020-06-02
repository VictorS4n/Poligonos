using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligonos
{
    /// <summary>
    /// Area que devuelva el area de un cuadrado
    /// </summary>
    public class Cuadrado
    {
        public double Lado { get; set; }
        public double Area 
        {
            get
            {
                return Lado * Lado;
            }
        }
    }
}
