using System;
namespace Generic_extension
{
    public class Program
    {
        static void Main(string[] args)
        {
            var obj = new { Name = "Arthur", Age = 18 };
            obj.ToJsonString();
            Console.WriteLine(obj);
            
            var objTwo = @"{'Name' : Arthur , Age = 18}";
            objTwo.FromJsonString();
            Console.WriteLine(objTwo);
        }
    }
}
