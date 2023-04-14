using System;
namespace Generic_extension
{
    public class Program
    {
        static void Main(string[] args)
        {
            var obj = new { Name = "Arthur", Age = 18 };
            var json = obj.ToJsonString();
            Console.WriteLine(json);
            
            var newObj = json.FromJson<{Name: String, Age: int}>();
            Console.WriteLine(newObj);
        }
    }
}
