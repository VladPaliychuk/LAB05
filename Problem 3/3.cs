using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main()
        {
            int age;
            string name;

            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Age: ");
            age = int.Parse(Console.ReadLine());

            Chicken c1 = new Chicken(name,age);
            c1.ProductPerDay();
        }
    }

    class Chicken
    {
        string name;
        int age;
        bool info = true;
        public Chicken(string name,int age)
        {
            if(name == null || name.Length == 0 || name==" ")
            {
                Console.WriteLine("Name cannot be empty");
                info = false;
            }
            else { this.name = name; }
            
            if(age<0 || age > 15)
            {
                Console.WriteLine("Age should be between 0 and 15.");
                info = false;
            }
            else { this.age = age; }
        }
        float CalculateProductPerDay()
        {
            float product;
            float n = age;
            product = n / 10;
            
            return product;
        }
        public void ProductPerDay()
        {
            if (info == true)
            {
                float n = CalculateProductPerDay();
                Console.WriteLine($"Chicken {name} (age {age}) can produce {n} eggs per day.");
            }
        }
    }
}
