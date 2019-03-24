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

            for (int i =1; i <= n; i++)
            {
             
                Console.Write($"product # " + i + " data: ");
                Console.WriteLine("Commn, used or imported (c/u/i) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'c'){
                    // Se for c não é importado e nem usado
                    /*Chama o list.add passando o objeto */
                    product.Add(new Product(name, price));
                } else if(ch == 'u'){
                    // Se for usado
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, date));
                } else {
                    Console.WriteLine("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add( new ImportedProduct(customFee, name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product prod in product){
                Console.WriteLine(prod.priceTag());
             
            }

            Console.ReadKey();

        }
    }
}
