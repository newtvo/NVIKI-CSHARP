using System;
using FirstNameSpace;
using FirstNameSpace.SecondNameSpace;

namespace FirstNameSpace
{
    public class Intro // khai bao class
    {
        public void sayHello() // Ham(method)
        {
            Console.WriteLine("I am in the first name space.");
        }
    }

    namespace SecondNameSpace
    {
        public class Introduction
        {
            public void sayHello()
            {
                Console.WriteLine("I am in the second name space");
            }
        }
    }
}

namespace HelloWorld
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    // Khai bao doi tuong tu class
        //    Intro intro = new FirstNameSpace.Intro();
        //    Introduction introduction = new FirstNameSpace.SecondNameSpace.Introduction();

        //    // In ket qua ra console
        //    intro.sayHello();
        //    introduction.sayHello();

        //    Console.ReadLine();
        //}
    }
}
