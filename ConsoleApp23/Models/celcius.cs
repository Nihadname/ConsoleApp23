using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Models
{
    internal class celcius
    {
        public double Celcius;
        public celcius(double Celciuss)
        {
            Celcius = Celciuss;
        }
        public static implicit operator Fahrenheit(celcius s)
        {
            return new Fahrenheit(s.Celcius/33.8);
        }
        

        }
    }

