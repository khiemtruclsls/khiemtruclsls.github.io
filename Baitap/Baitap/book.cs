using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class book

    {
        //   private String bookName;
        public string BookName { get; set; }

        //  private String bookAuthor;
        public string BookAuthor { get; set; }
        // private String producer;
        public string Producer { get; set; }
        // private int yearPublishing;
        public int YearPublishing { get; set; }

        private float _price;
        public float Price
        {
            get
            {
                return _price;
            }

            set
            {
               
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Cai dat price sai");
                }
            }
        }

        public book()
        {
        }

        public book(string bookName, string bookAuthor, string producer, int yearPublishing, float price)
        {
            BookName = bookName;
            BookAuthor = bookAuthor;
            Producer = producer;
            YearPublishing = yearPublishing;
            Price = price;
        }
        public virtual void input()
        {
            Console.WriteLine("Please enter a title : ");
            BookName = Console.ReadLine();
            Console.WriteLine("Please enter the author's name : ");
            BookAuthor = Console.ReadLine();
            Console.WriteLine("Please enter the manufacturer  : ");
            Producer = Console.ReadLine();
            Console.WriteLine("Please enter the year of publication  : ");
            YearPublishing = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the price : ");
            Price = float.Parse(Console.ReadLine());
        }
        public void disalay() {
            Console.WriteLine("the name of the book is : "+ BookName);
            Console.WriteLine("the author's name is  : "+ BookAuthor);
            Console.WriteLine("manufacturer is : "+ Producer);
            Console.WriteLine("year of publication was :  "+ YearPublishing);
            Console.WriteLine("Price is : "+ Price);
  


        }
    }
}
