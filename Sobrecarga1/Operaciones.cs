using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    public class Operaciones
    {
       //Creación de la sobrecarga de metodo
        public double Multiplicar(double a, double b)
        {

            return a * b;
        }
        public double Multiplicar(double a)
        {

            return a * 2;
        }
        public double Multiplicar()
        {

            return 2 * 1;
        }
    }
}
