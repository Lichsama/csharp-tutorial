using System;
using System.Collections;


namespace HashTableChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable StudentsTable = new Hashtable();
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);


            foreach(Student s in students) 
            {
               if(!StudentsTable.ContainsKey(s.Id)) 
                {
                  StudentsTable.Add(s.Id, s);
                    Console.WriteLine("Student with ID{0} was Added!", s.Id);
                }
                else
                {
                    Console.WriteLine("Sorry, A student with the same Id already Exists ID:{0}",s.Id);
                }
            
            }


        }


    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}