using Newtonsoft.Json;
namespace Generic_extension
{
    public static class JsonExtensions
    {
        public static string ToJsonString<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
