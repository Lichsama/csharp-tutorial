using System;
using System.Collections;


namespace Hashtables
{
    internal class Program
    {
        // Key - Value
        // Auto - Car


        static void Main(string[] args)
        {
            Hashtable  studentstable = new Hashtable();
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentstable.Add(stud1.Id, stud1);
            studentstable.Add(stud2.Id, stud2);
            studentstable.Add(stud3.Id, stud3);
            studentstable.Add(stud4.Id, stud4);

            // retrieve individual item with known ID
            Student storedStudent1 = (Student)studentstable[1];

            // retrieve all
            foreach(DictionaryEntry entry in studentstable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}",temp.Id);
                Console.WriteLine("Student Name:{0}",temp.Name);
                Console.WriteLine("Student GPA:{0}",temp.GPA);

            }

            foreach( Student temp in studentstable.Values )
            {
                Console.WriteLine("Student ID:{0}", temp.Id);
                Console.WriteLine("Student Name:{0}", temp.Name);
                Console.WriteLine("Student GPA:{0}", temp.GPA);
            }

            Console.WriteLine("Student ID:{0} Name:{1} GPA:{2}",storedStudent1.Id,storedStudent1.Name,storedStudent1.GPA);

        }


    }

    class Student
    {
        //property called Id
        public int Id { get; set; }

        // property called Name
        public string Name { get; set; }

        //property called GPA
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }

    }
}