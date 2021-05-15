using System;

/* Запросить у пользователя: фамилию, имя, возраст, вес, рост.
Высчитать ИМТ(индекс массы тела) по формуле ИМТ = вес (кг) / (рост(м) * рост(м))
Сформировать единую строку, в следующем формате:
Your profile:
Full Name: фамилия, имя
Age: возраст
Weight: вес
Height: рост
Body Mass Index: ИМТ
Вывести сформированную строку на консоль. */

namespace CSharpCoursePractice
{
    public class UserProfile
    {
        public UserProfile()
        {
            Console.WriteLine("Last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("First name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Age:");
            string age = Console.ReadLine();

            Console.WriteLine("Weight (kg):");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Height (cm):");
            int height = int.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height / 100);

            Console.WriteLine("");
            Console.WriteLine("Your profile:");
            Console.WriteLine($"Full Name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}kg");
            Console.WriteLine($"Height: {height}cm");
            Console.WriteLine($"Body Mass Index: {bodyMassIndex}");
        }
    }
}
