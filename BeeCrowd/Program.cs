using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.Design.Serialization;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;

            A = Convert.ToDouble(Console.ReadLine(),CultureInfo.CreateSpecificCulture("en-US"));
            B = Convert.ToDouble(Console.ReadLine(),CultureInfo.CreateSpecificCulture("en-US"));
            MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.CreateSpecificCulture("en-US")));
            Console.ReadKey();

        }
    }
}
