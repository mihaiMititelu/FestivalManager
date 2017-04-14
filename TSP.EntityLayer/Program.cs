using System;
using System.Data.Entity;
using System.Linq;

namespace TSP.EntityLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new FestivalContainer())
            {
                var festival = new Festival
                {
                    DateAndTime = DateTime.Now,
                    Id = Guid.NewGuid(),
                    Name = "da doamne sa mearga ca-mi bag pl",
                    Location = new Location
                    {
                        Id = Guid.NewGuid(),
                        Name = "undeva departe de .net",
                        Capacity = "45"
                    }
                };

                db.Festivals.Add(festival);
                db.SaveChanges();
                Console.WriteLine(db.Festivals.FirstOrDefault()?.Name);
                Console.WriteLine(db.Festivals.Include(f => f.Location).FirstOrDefault()?.Location.Name);
            }
        }
    }
}