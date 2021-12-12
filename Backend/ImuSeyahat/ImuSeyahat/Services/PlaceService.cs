using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImuSeyahat.Models;
using ImuSeyahat.DbHelpers;

namespace ImuSeyahat.Services
{
    public class PlaceService : IPlaceService 
    {
        private IPlaceDb _placeDb;
        public PlaceService(IPlaceDb placeRepository)
        {
            _placeDb = placeRepository;
        }
        public async Task<Place> CreatePlace(Place place)
        {
            return await _placeDb.CreatePlace(place);
        }

        public async Task DeletePalceByName(string name)
        {
            await _placeDb.DeletePalceByName(name);
        }

        public async Task DeletePlaceById(int id)
        {
            await _placeDb.DeletePlaceById(id);
        }

        public async Task<List<Place>> GetAllPlaces()
        {
            return await _placeDb.GetAllPlaces();
        }

        public async Task<Place> GetPlaceById(int id)
        {
            return await _placeDb.GetPlaceById(id);
        }

        public async Task<Place> GetPlaceByName(string name)
        {
            return await _placeDb.GetPlaceByName(name);
        }

        public async Task<Place> GetPlacesByNameOfCity(string name)
        {
            return await _placeDb.GetPlacesByNameOfCity(name);
        }

        public async Task<Place> UpdatePlace(Place place)
        {
            return await _placeDb.UpdatePlace(place);
        }
    }
}
