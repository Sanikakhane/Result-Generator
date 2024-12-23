using System;

namespace Result_gen
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Student s1 = new Student(1, "Sanika");
            s1.addMarks(98);
            s1.addGrade(98);

            s1.addMarks(97);
            s1.addGrade(97);

            s1.addMarks(95);
            s1.addGrade(95);

            s1.addMarks(95);
            s1.addGrade(95);

            s1.addMarks(95);
            s1.addGrade(95);

            //Console.WriteLine(s1.calculate_percentage());
            s1.show_grade();
            s1.show_result();
        }
    }
}