using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityGuide.Models
{
    public class City
    {
        public City()
        {
             Photos = new List<Photo>();
        }
       
        public long Id { get; set; }  
        public string Description{ get; set; }
        public string Name{ get; set; }
        public long UserId { get; set; } 

       public List<Photo> Photos { get; set; } 
        public User User { get; set; } 
    }
}