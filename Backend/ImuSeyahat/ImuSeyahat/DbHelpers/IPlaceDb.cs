using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImuSeyahat.Models;

namespace ImuSeyahat.DbHelpers
{
    public interface IPlaceDb
    {
        Task<List<Place>> GetAllPlaces();

        Task<Place> GetPlaceById(int id);
        Task<Place> GetPlaceByName(string name);
        Task<Place> GetPlacesByNameOfCity(string name);
        Task<Place> CreatePlace(Place place);

        Task<Place> UpdatePlace(Place place);
        Task DeletePalceByName(string name);
        Task DeletePlaceById(int id);
    }
}
