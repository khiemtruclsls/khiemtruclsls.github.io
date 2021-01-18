using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class AptachBook : book
    {
        public String Language { get; set; }
        public String Semester { get; set; }

        public AptachBook()
        {
        }

        public AptachBook(string bookName, string bookAuthor, string producer, int yearPublishing, float price ,string language, string semester) : base ( bookName,  bookAuthor,  producer,  yearPublishing, price)
        {
            Language = language;
            Semester = semester;
        }
        public override void input()
        {
            base.input();
            Console.WriteLine("please enter language  : ");
            Language = Console.ReadLine();
            Console.WriteLine("Pleasw enter semester : ");
            Semester = Console.ReadLine();
        }
        public  void isalay()
        {
            base.disalay();
            Console.WriteLine(" language  : "+Language);
            Console.WriteLine("semester : "+Semester);
        }
    }
}
