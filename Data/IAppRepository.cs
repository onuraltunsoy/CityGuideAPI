using System.Collections.Generic;

using CityGuide.Models;

namespace CityGuide.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entitiy) where T:class;
        void Delete<T>(T entitiy)where T:class;
        bool SaveAll();

        List<City> GetAllCities();
        List<Photo> GetAllPhotosByCity(long cityId);
        City GetCityById(long cityId);
        Photo GetPhoto(long id);
    }
}