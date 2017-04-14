using System;

namespace TSP.WcfLayer.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new FestivalClient();
            var x = client.GetFestivalByName("da doamne sa mearga ca-mi bag pl");
            Console.WriteLine(x.Location);
            Console.WriteLine(x.DateAndTime);
            Console.WriteLine(x.Name);
            Console.WriteLine(x.Id);
        }
    }
}