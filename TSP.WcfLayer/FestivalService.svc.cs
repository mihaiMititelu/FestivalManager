using System;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using TSP.EntityLayer;

namespace TSP.WcfLayer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class FestivalService : IFestival
    {
        private readonly FestivalContainer _db = new FestivalContainer();

        public Festival GetFestivalByName(string name)
        {
            return _db.Festivals
                .Include(f => f.Location)
                .Include(f => f.Performers)
                .Include(f => f.Tickets)
                .FirstOrDefault(f => f.Name.Equals(name));
        }

        public Festival[] GetAllFestivals()
        {
            return _db.Festivals
                .Include(f => f.Location)
                .Include(f => f.Performers)
                .Include(f => f.Tickets)
                .ToArray();
        }

        public void CreateNewFestival(Festival festival)
        {
            if (festival == null) return;
            festival.Id = Guid.NewGuid();
            _db.Festivals.Add(festival);
            _db.SaveChanges();
        }

        public void AddLocationToFestival(string festivalName, Location location)
        {
            throw new NotImplementedException();
        }

        public void AddPerformerToFestival(string festival, Performer performer)
        {
            var fest = _db.Festivals.FirstOrDefault(f => f.Name.Equals(festival));
            performer.Id = Guid.NewGuid();
            fest?.Performers.Add(performer);
            _db.SaveChanges();
        }

        public void AddTicketToFestival(string festival, Ticket ticket)
        {
            var fest = _db.Festivals.FirstOrDefault(f => f.Name.Equals(festival));
            ticket.Id = new Random().Next(int.MinValue, int.MaxValue);
            fest?.Tickets.Add(ticket);
            _db.SaveChanges();
        }

        public void DeleteFestival(string festivalName)
        {
            throw new NotImplementedException();
        }

        public void DeleteLocationFromFestival(string festivalName)
        {
            throw new NotImplementedException();
        }

        public void DeletePerformerFromFestival(string festivalName)
        {
            throw new NotImplementedException();
        }
    }
}