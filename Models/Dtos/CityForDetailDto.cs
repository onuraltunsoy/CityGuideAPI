using System.Collections.Generic;

namespace CityGuide.Models.Dtos
{
    public class CityForDetailDto
    {
    
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Photo> Photos{ get; set; }
    }
}