using System;

namespace Observer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var subject = new Subject();
            var objectA = new ObjectA();
            var objectB = new ObjectB();
            
            subject.Attach(objectA);
            subject.Attach(objectB);
            subject.Notify("Вывел новое сообщение");
            
            Console.WriteLine();
            subject.Detach(objectA);
            subject.Notify("Вывел новое сообщение");
            Console.ReadKey();
        }
    }
}