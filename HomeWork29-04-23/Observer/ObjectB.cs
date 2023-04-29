using System;

namespace Observer
{
    public class ObjectB : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Статус класса B {message}");
        }
    }
}