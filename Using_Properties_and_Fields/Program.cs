using System;
using System.Text;
namespace Using_Properties_and_Fields
{

    class Program
    {

        static void Main(string[] args)
        {

            Person p = new Person();
            p.Age= 65;

            Console.WriteLine("Age :" + p.Age);

        }


        public class Person
        {
            private int age;
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                   if ((value > 0) && (value <65 ))
                    {

                        age = value;

                    }
                    else
                    {

                        throw new Exception("Age cannot be over 65");
                    }
                }
            }


        }
    }
}