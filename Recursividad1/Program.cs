using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad1
{
    public class Program
    {
        void Imprimir(int x)
        {
            if (x > 0)
            {
                Imprimir(x - 1);
                Console.WriteLine(x);
            }
        }
        static void Main(string[] args)
        {
            Program re = new Program();            
            re.Imprimir(50);  //Cambiamos el numero por el cual deseamos obtener la recursividad            
            Console.ReadKey(); 
        }
    }
}
