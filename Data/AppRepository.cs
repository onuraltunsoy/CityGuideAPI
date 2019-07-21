using System.Collections.Generic;
using System.Linq;
using CityGuide.Models;
using Microsoft.EntityFrameworkCore;

namespace CityGuide.Data
{
    public class AppRepository : IAppRepository
    {
        private readonly DataContext _context;
        public AppRepository(DataContext context)
        {
            _context = context;
          
        }

        public void Add<T>(T entitiy) where T : class
        {
            _context.Add(entitiy);
        }

        public void Delete<T>(T entitiy) where T : class
        {
            _context.Remove(entitiy);
        }

        public List<City> GetAllCities()
        {
            var cities = _context.Cities.Include(c => c.Photos).ToList();
            return cities;
        }
        public City GetCityById(long cityId)
        {
            var city = _context.Cities.Include(c => c.Photos).FirstOrDefault(c => c.Id == cityId);
            return city;
        }

        public List<Photo> GetAllPhotosByCity(long id)
        {
            var photos = _context.Photos.Where(p => p.CityId == id).ToList();
            return photos;
        }



        public Photo GetPhoto(long cityId)
        {
            var photo = _context.Photos.FirstOrDefault(c => c.Id == cityId);
            return photo;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}