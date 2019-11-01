using System;

namespace classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object syntax
            //type identifier = new type();
            Student s1 = new Student();
            s1.name = "Ahmed Mohamed";
            Console.WriteLine(s1.name);
            Teacher t1 = new Teacher();
            t1.name = "Mohamed Fathy";
            Console.WriteLine(t1.name);
        }
    }
    class Student
    {
        //class members
        //fiels = class data
        public string name;

    }
    struct Teacher
    {
        //fiels = class data
        public string name;
    }

}
