using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultadosVotacion2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Número de votos por el partido 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos por el partido 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Número total de la población de todas las edades");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje de la población que es mayor de edad");
            double p = double.Parse(Console.ReadLine());

            bool A = (a + b + blancos + anulados) > n;
            bool B = Math.Abs(a - b) < ((a + b + blancos + anulados) * 0.1);
            bool C = (a + b + blancos + anulados) < (n * 0.3);

            if ((A || B) && C) Console.WriteLine("Las elecciones deben ser ejecutadas nuevamente");
            else if (a > b) Console.WriteLine("El partido 1 es el ganador");
            else Console.WriteLine("El partido 2 es el ganador");
        }
    }
}
