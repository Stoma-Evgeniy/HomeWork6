using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();

            //Group group = new Group();

            double averagerating;
            double result = 0;


            student1.Name = "Alex";
            student1.Surname = "Kirkorov";
            student1.grades = new int [] { 3, 4, 9, 6, 7 };

            student2.Name = "Igor";
            student2.Surname = "Kamysh";
            student2.grades = new int[] { 6, 8, 9, 6, 7 };

            //group.Number = 1;
            //group.ListOfStudents = student1.Name;

            for (int i = 0; i < student1.grades.Length; i++)
            {
                result =+ student1.grades[i];
                
            }

            averagerating = result / student1.grades.Length ;
            Console.WriteLine("Студент "+ student1.Name + " " + student1.Surname + " имеет средний балл: " + averagerating);

            for (int i = 0; i < student1.grades.Length; i++)
            {
                Console.Write(student1.grades[i] + " ");
            }
        }
    }
}
