using System;

/* Запросить у пользователя длины трёх сторон треугольника. Длины могут быть представлены дробными значениями.
После получения длин сторон - использовать формулу Герона для вычисления площади треугольника.
Чтобы жизнь не казалась мёдом найдите формулу самостоятельно.
После вычисления площади - вывести результат на консоль. */

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
