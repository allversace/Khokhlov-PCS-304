﻿namespace LabTwo
{
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person { Name = "Артур", Age = 19 };
            person.Validate();
        }
    }
}