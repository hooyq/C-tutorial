using System;

class Hello
{
    public void wr()
    {
        Console.WriteLine("outside");
        Console.ReadLine();
    }
}

namespace Program  //a higher abstraction from a class 
{
    public class Program
    {
        static void Main(string[] args)   //only one entry is available 
        {
            Hello hello = new Hello();  //can be use before define
            Hello hello2 = new Hello();
            hello2.wr();
            hello.wr();
            global::Hello h = new global::Hello();   //need to use global
            h.wr();
        }
    }

    public class Hello
    {
        public void wr()
        {
            Console.WriteLine("inside");
            Console.ReadLine();
        }
    }
}





