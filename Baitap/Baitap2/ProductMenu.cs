using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    class ProductMenu
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            int n, choose = 0;
            while (choose != 4 ) {
                ShowMenu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Nhap N San pham : ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("product  : " + (i + 1));
                            Product product = new Product();
                            product.Input();
                            products.Add(product);
                        }
                        break;
                    case 2:
                        foreach (Product pro in products)
                        {
                            pro.Display();
                        }
                        break;
                    case 3:
                        for (int i = 0; i < products.Count; i++)
                        {
                            for (int j = i + 1; j < products.Count; j++)
                            {
                                if (products[i].Price < products[j].Price)
                                {
                                    //cach trao doi gia tri
                                    Product tmp = products[i];
                                    products[i] = products[j];
                                    products[j] = tmp;
                                }
                            }
                        }
                        for (int i = 0; i < products.Count; i++)
                        {
                            Console.WriteLine("Product  : " + (i + 1));
                            products[i].Display();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exit......");
                        break;
                    default:
                        Console.WriteLine("Please choose again.");
                        break;
                }

            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("1.Enter information for n products");
            Console.WriteLine("2.Display the information you have entered");
            Console.WriteLine("3.Sort descending information by price and display");
            Console.WriteLine("4.Exit");
            Console.Write("Choose: ");
        }
    }
}
