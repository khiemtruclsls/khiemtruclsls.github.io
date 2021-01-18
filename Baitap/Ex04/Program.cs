using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Programs
    {
        static void Main(string[] args)
        {
            List<Student> Liststd = new List<Student>();
            int choose = 0;
            int n=0;
            while(choose != 4)
            {
                Console.WriteLine("1 please enter infomation ");
                Console.WriteLine("2 show student infomation ");
                Console.WriteLine("3 Sort information descending by age");
                Console.WriteLine("4 Exit........");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        //dùng để nhập thông tin 
                        Console.WriteLine("Please enter the number of students :");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++) {
                            Console.WriteLine("Student : " + (i + 1));
                            Student student = new Student();
                            student.Input();
                            Liststd.Add(student);
                        }
                        break;
                    case 2:
                        //Dùng để hiển thỉ thông tin đã nhập 

                       for(int i = 0; i< Liststd.Count; i++)
                        {
                            Console.WriteLine("Student : " + (i + 1));
                            Liststd[i].output();
                        }
                        break;
                    case 3:
                        //thuật toán sắp xếp tuổi giảm dần ta pải tạo 1 biến tạm đển chữa giá trị 

                        for(int i= 0; i < Liststd.Count; i++)
                        {
                            for(int j = i + 1; j < Liststd.Count; j++)
                            {
                                if(Liststd[i].age < Liststd[j].age)
                                {
                                    Student temp = Liststd[i];
                                    Liststd[i] = Liststd[j];
                                    Liststd[j] = temp;
                                }
                            }
                        }
                        foreach (Student student in Liststd) {
                            student.output();
                        }


                        /*for (int i = 0; i < Liststd.Count - 1; i++)
                        {
                            for (int j = i + 1; j < Liststd.Count; j++)
                            {
                                if (Liststd[i].age < Liststd[j].age)
                                {
                                    Student temp = Liststd[i];
                                    Liststd[i] = Liststd[j];
                                    Liststd[j] = temp;
                                }
                            }
                        }
                        for (int i = 0; i < Liststd.Count; i++)
                        {
                            Console.WriteLine("Student : " + (i + 1));
                            Liststd[i].output();
                        }*/
                        break;
                    case 4:
                        Console.WriteLine("Bye");

                        break;
                }
            }
        }
    }
}
