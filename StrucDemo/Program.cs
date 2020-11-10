using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrucDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Init
            //Student s1 = new Student();
            //s1.Name = "Kenan";
            //s1.Age = 25;
            //s1.IsMarried = true;
            //Console.WriteLine($"{s1.Name} {s1.Age} {s1.Ismarried}");

            //Student s2 = new Student();
            //s2.Name = "Kenan";
            //s2.Age = 25;
            //s2.IsMarried = false;
            //Console.WriteLine($"{s2.Name} {s2.Age} {s2.Ismarried}");

            //Student s3 = new Student() { name = "Jan", Age = 22, IsMarried = false };
            //Console.WriteLine($"{s3.Name} {s3.Age} {s3.IsMarried}");

            //Student s4 = new Student()
            //{
            //    Name = "Tom",
            //    Age = 26,
            //    IsMarried = true
            //};

            //Console.WriteLine($"{s4.Name}{s4.Age}{s4.IsMarried}");
            #endregion

            #region Constructor

            Student s4 = new Student();
            

           
            #endregion

        }
        public struct Student
        {
            public static string Name = "Kenan";
            public int Age;
            public bool IsMarried;
        }
    }
}
