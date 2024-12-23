using System;
using System.Collections.Generic;



namespace Result_gen
{
    public class Person
    {
        public int Id { get; set; }
        public string name { get; set; }
        public Person(int id, string name)
        {
            Id = id;
            this.name = name;
        }
    }

    public class Student : Person 
    {
        public List<string> subjects;
        public List<double> subject_marks;
        public double total_marks;
        public double percentage;
        public List<char> grades;
        public char final_grade;
        public Student(int Id,string name) :base(Id ,name)
        {
            subjects = new List<string>() { "English","Hindi  ","Maths  ","History","Science"};
            subject_marks = new List<double>();
            total_marks = 0;
            percentage = 0;
            grades = new List<char>();
            final_grade = 'A';
        }


        public void addMarks(double mark)
        {
            subject_marks.Add(mark);
        }
        public void addGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                switch (grade)
                {
                    case double n when n >= 90:
                        grades.Add('A');
                        break;
                    case double n when n >= 80:
                        grades.Add('B');
                        break;
                    case double n when n >= 70:
                        grades.Add('C');
                        break;
                    case double n when n >= 60:
                        grades.Add('D');
                        break;
                    case double n when n >= 50:
                        grades.Add('E');
                        break;
                    default:
                        Console.WriteLine("Invlaid marks");
                        break;

                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }
        public void calculate_percentage()
        {
            foreach(double mark in subject_marks)
            {
                total_marks += mark;
            }
            percentage =  (total_marks / 5);
        }
        public void show_grade()
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine($"{subjects[i]}         {grades[i]}");
            }
        }
        public void show_result()
        {
            Console.WriteLine("***********************************************************************");
            Console.WriteLine($"Id :- {Id}   Name :-   {name}");
            Console.WriteLine("Subject        Marks    Grade");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine($"{subjects[i]}     {subject_marks[i]}     {grades[i]}");
            }
            calculate_percentage();
            Console.WriteLine($"The Percentage of {name} is  {percentage}");

        }


    }
}