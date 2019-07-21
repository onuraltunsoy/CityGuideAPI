using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CityGuide.Data;
using CityGuide.Models;
using CityGuide.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CityGuide.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IAppRepository _appRepository;
        private IMapper _mapper;
        public CitiesController(IAppRepository appRepository, IMapper mapper)
        {
            this._appRepository = appRepository;
            this._mapper = mapper;

        }

        [HttpGet(Name = "Get All Cities")]
        public ActionResult<List<City>> GetAll()
        {
            var cities = _appRepository.GetAllCities();
            var citiesToReturn = _mapper.Map<List<CityForListDto>>(cities);
            return Ok(citiesToReturn);
        }



        [HttpPost(Name = "Save City")]
        public ActionResult<City> saveCity([FromBody]City city)
        {
            _appRepository.Add(city);
            _appRepository.SaveAll();
            return Ok();
        }
        [HttpGet("{id}", Name = "GetCity")]
        /////[Route("")]
        public ActionResult<City> GetById(long id)
        {
            var city = _appRepository.GetCityById(id);
           var cityToReturn = _mapper.Map<CityForDetailDto>(city);
            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
        [HttpGet("photos/{cityId}", Name = "Get Photo By City Id")]
        public ActionResult<City> GetPhotosByCityId(long cityId)
        {
            var photos = _appRepository.GetAllPhotosByCity(cityId);
          
            return Ok(photos);
        }







    }
}