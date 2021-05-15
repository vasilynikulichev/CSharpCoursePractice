using System;

namespace CSharpCoursePractice
{
    public class HeronFormula
    {
        public HeronFormula()
        {
            Console.WriteLine("ab = ");
            double ab = int.Parse(Console.ReadLine());
            Console.WriteLine("bc = ");
            double bc = int.Parse(Console.ReadLine());
            Console.WriteLine("ca = ");
            double ca = int.Parse(Console.ReadLine());

            double p = (ab + bc + ca) / 2;
            double s = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
            Console.WriteLine($"ab = {ab}; bc = {bc}; ca = {ca};");
            Console.WriteLine("S = " + s);
        }
    }
}
