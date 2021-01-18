using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AptachBook> Listbook = new List<AptachBook>();
            int choose = 0;
            int n;
            while (choose != 6)
            {
                showmenu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("please enter N = ");
                         n = int.Parse(Console.ReadLine());
                        for(int i = 0; i< n; i++)
                        {
                            Console.WriteLine("book : "+ (i + 1));
                            AptachBook book1 = new AptachBook();
                            book1.input();
                            Listbook.Add(book1);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < Listbook.Count; i++)
                        {
                            Console.WriteLine("book : " + (i + 1));
                            Listbook[i].disalay();
                        }
                        break;
                    case 3:
                        for (int i = 0; i < Listbook.Count; i++)
                        {
                            for (int j = i + 1; j < Listbook.Count; j++)
                            {
                                if (Listbook[i].Price < Listbook[j].Price)
                                {
                                    //cach trao doi gia tri
                                    AptachBook tmp = Listbook[i];
                                    Listbook[i] = Listbook[j];
                                    Listbook[j] = tmp;
                                }
                            }
                        }
                        for (int i = 0; i < Listbook.Count; i++)
                        {
                            Console.WriteLine("book : " + (i + 1));
                            Listbook[i].disalay();
                        }
                        break;
                    case 4:
                        Console.WriteLine("TIM KIEM TEN SACH :");
                        string seach = Console.ReadLine();
                        for (int i = 0; i < Listbook.Count; i++)
                        {
                            if (Listbook[i].BookName .Equals(seach) ){
                                Listbook[i].disalay();
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("TIM KIEM TEN TAC GIA :");
                        string seachs = Console.ReadLine();
                        for (int i = 0; i < Listbook.Count; i++)
                        {
                            if (Listbook[i].BookAuthor.Equals(seachs) ){
                                Listbook[i].disalay();
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("bye");
                        break;
                    default:
                        Console.WriteLine("Lua chon sai");
                        break;
                }
            }
    }
        public static void showmenu()
        {   
            Console.WriteLine("************************");
            Console.WriteLine(" 1. Insert n book");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Sort");
            Console.WriteLine("4. Search by Name");
            Console.WriteLine("5. Search by Author");
            Console.WriteLine("6. Exit");
            Console.Write("Choose: ");
        }
   }
}
