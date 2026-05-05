using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            retangulo ret = new retangulo(); 

            Console.WriteLine("entre a largura e a altura o retangulo:");
            ret.largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            ret.altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("area = "+ret.area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("perimetro = " + ret.perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("diagonal =" + ret.diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
