using System;
using System.ComponentModel.DataAnnotations;

namespace CityGuide.Models
{
    public class Photo
    {
    
        public long Id { get; set; }
        public long CityId { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        
        public City City{ get; set; }

    }
}