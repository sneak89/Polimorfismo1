using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo1
{
    internal class Carroceria : Carro
    {
        //Atributos
        private double bas { get; set; }
        private double altura { get; set; }

        //Constructor
        public Carroceria(string c, double b, double a) 
        { 
            color = c;
            this.bas = b;
            this.altura = a;
        }

        //Metodo
        public string MostrarArea()
        {
            string datos;
            double area1;
            area1 = bas * altura;
            datos = "El color de la carroceria es: " + color + Environment.NewLine;
            datos += "El area de la carroceria es: " + area1 + Environment.NewLine;
            return datos; 
        }
    }
}
