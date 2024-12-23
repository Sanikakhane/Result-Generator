using System;

namespace Result_gen
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter the Id and name of the student");
            int id=0;
            try
            {
                var inp = Console.ReadLine();
                id = int.Parse(inp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var input = Console.ReadLine();
            string name=input;
            Student s1 = new Student(id, name);
            List<string> sub = s1.subjects;
            Console.WriteLine("Enter Marks of Subjects ");
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("Enter the marks for "+sub[i]);
                    var a = Console.ReadLine();
                    int mark=int.Parse(a);
                    if(mark>=0&&mark<=100)
                    {
                        s1.add_marks(mark);
                        s1.add_grade(mark);
                    }
                    else
                    {
                        Console.WriteLine("The marks are invalid");
                        i--;
                    }
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
                
            }
            s1.show_result();
        }
    }
}