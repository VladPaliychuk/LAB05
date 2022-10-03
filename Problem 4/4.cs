using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4
{
    internal class Program
    {
        static void Main()
        {
            string name = null;
            int money = 0, cost = 0;

            List<Person> persons = new List<Person>(); 
            List<Product> products = new List<Product>();

            string[] InfoPersons = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(var InfoPerson in InfoPersons)
            {
                var InfoPersonAr = InfoPerson.Split('=');
                name = InfoPersonAr[0];
                money = int.Parse(InfoPersonAr[1]);
                var person = new Person(name, money);
                persons.Add(person);
            }

            var InfoProducts = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var InfoProduct in InfoProducts)
            {
                string[] InfoProductAr = InfoProduct.Split('=');
                name = InfoProductAr[0];
                cost = int.Parse(InfoProductAr[1]);
                var product = new Product(name, cost);
                products.Add(product);
            }

            string line = Console.ReadLine();
            while(!line.Equals("END"))
            {
                var NameProductStr = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                name = NameProductStr[0];
                string product = NameProductStr[1];
                    for(int i = 0; i < persons.Count; i++)
                    {
                        if (name == persons[i].Name)
                        {
                            for(int j=0; j < products.Count; j++)
                            {
                                if (product == products[i].Name)
                                {
                                    if (products[i].Cost <= persons[i].Money)
                                    {
                                        persons[i].Products.Add(products[i]);
                                        persons[i].Money -= products[i].Cost;

                                        Console.WriteLine($"{persons[i].Name} bought {products[i].Name}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{persons[i].Name} can't afford {products[i].Name}");
                                    }
                                }
                            }
                        }
                    }

                //}
                line = Console.ReadLine();
                
            }

            foreach (var person in persons)
            {
                if (!person.Products.Any()) // (Any) директива using System.Linq;
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                    continue;
                }

                Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
            }
        }
    }

    class Person
    {
        string name;
        int money;
        public List<Product> Products { get; set; }
        public Person(string name, int money)
        {
            if (name == null || name.Length == 0 || name == " ")
            {
                Console.WriteLine("Name cannot be empty");
            }
            else { this.name = name; }

            if (money < 0)
            {
                Console.WriteLine("Money cannnot be a negative number");
            }
            else { this.money = money; }

            this.Products = new List<Product>();
        }
        
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Money 
        {
            get { return this.money; }
            set { this.money = value; }
        }
    }
    class Product
    {
        string name;
        int cost;
        public Product(string name, int cost)
        {
            if (name == null || name.Length == 0 || name == " ")
            {
                Console.WriteLine("Name cannot be empty");
            }
            else { this.name = name; }

            if (cost < 0)
            {
                Console.WriteLine("Cost cannnot be a negative number");
            }
            else { this.cost = cost; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }
    }
}
