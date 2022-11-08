using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> people = new List<Person>();
                List<Product> products = new List<Product>();

                List<string> peopleInfo = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                List<string> productInfo = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                Reading(people, products, peopleInfo, productInfo);

                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                while (cmdArgs[0] != "END")
                {
                    string personName = cmdArgs[0];
                    string productName = cmdArgs[1];

                    Person person = people.FirstOrDefault(x => x.Name == personName);
                    Product product = products.FirstOrDefault(x => x.Name == productName);

                    if (person != null && product != null)
                        person.Purchase(product);

                    cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


        private static void Reading(List<Person> people, List<Product> products, List<string> peopleInfo, List<string> productInfo)
        {
            foreach (var per in peopleInfo)
            {
                string[] currPerson = per.Split("=", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(currPerson[0], decimal.Parse(currPerson[1]));
                people.Add(person);
            }

            foreach (var product in productInfo)
            {
                string[] currProduct = product.Split("=", StringSplitOptions.RemoveEmptyEntries);

                Product product1 = new Product(currProduct[0], decimal.Parse(currProduct[1]));
                products.Add(product1);
            }
        }
    }
}

