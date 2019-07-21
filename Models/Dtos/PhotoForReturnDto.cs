using System;

namespace CityGuide.Models.Dtos
{
    public class PhotoForReturnDto
    {
        public long Id { get; set; }
        public string Url { get; set; }
        public string Descripton { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
    }
}