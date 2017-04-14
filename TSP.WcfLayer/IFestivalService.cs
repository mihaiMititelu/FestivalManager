using System;
using System.ServiceModel;
using TSP.EntityLayer;

namespace TSP.WcfLayer
{
    [ServiceContract]
    public interface IFestival
    {
        [OperationContract]
        Festival GetFestivalByName(string name);

        [OperationContract]
        Festival[] GetAllFestivals();

        [OperationContract]
        void CreateNewFestival(Festival festival);

        [OperationContract]
        void AddLocationToFestival(string festivalName, Location location);

        [OperationContract]
        void AddPerformerToFestival(string festivalName, Performer performer);

        [OperationContract]
        void AddTicketToFestival(string festivalName, Ticket ticket);

        [OperationContract]
        void DeleteFestival(string festivalName);

        [OperationContract]
        void DeleteLocationFromFestival(string festivalName);

        [OperationContract]
        void DeletePerformerFromFestival(string festivalName);
    }
}