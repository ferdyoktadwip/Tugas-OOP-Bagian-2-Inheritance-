using System;

namespace LatihanInheritanceReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ferdy", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Bella", 35, 190302, "Guru Ekonomi");
            teacher.GetNameAndAge();

            Student student = new Student("Cindy", 21, 10506, "cindywidyawati@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
