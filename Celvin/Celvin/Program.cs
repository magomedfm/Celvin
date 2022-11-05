using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celvin
{
    class Program
    {


        private static void Main(string[] args)
        { 
        }
        class Degree
        {

            static float Celsius_to_Kelvin(float C)
            {
                return (float)(C + 273.15);
            }


            public static void Main()
            {
                float C = 100;

                Console.WriteLine("Temp in Kelvin ( K ) = " + Celsius_to_Kelvin(C));
            }
        }
    

    }

}

