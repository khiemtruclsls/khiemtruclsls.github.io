﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    class Product
    {
        public string ProductName { get; set; }
        public string ProducerName { get; set; }

        public float Price { get; set; }

        public Product() { }

        public Product(string productName, string producerName, float price)
        {
            ProductName = productName;
            ProducerName = producerName;
            Price = price;
        }

        public void Input()
        {
            Console.Write("Enter product name: ");
            ProductName = Console.ReadLine();
            Console.Write("Enter producer name: ");
            ProducerName = Console.ReadLine();
            Console.Write("Enter product price: ");
            Price = float.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Product name: {0}, producer: {1}, price: {2}", ProductName, ProducerName, Price);
        }
    }
}
