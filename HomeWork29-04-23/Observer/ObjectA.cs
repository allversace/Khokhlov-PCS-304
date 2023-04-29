using System;

namespace Observer
{
    public class ObjectA : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Статус класса A {message}");
        }
    }
}