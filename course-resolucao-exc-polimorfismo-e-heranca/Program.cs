using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using course_resolucao_exc_polimorfismo_e_heranca.Entities;

namespace course_resolucao_exc_polimorfismo_e_heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> product = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i =0; i <= n; i++)
            {
                Console.WriteLine("Commn, used or imported (c/u/i) ? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write($"product #{i} data: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Custom fee: ");
                double custom = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

        }
    }
}
