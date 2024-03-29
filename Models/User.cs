using System.Collections.Generic;

namespace CityGuide.Models
{
    public class User
    {
        public User()
        {
            Cities  = new List<City>();
        }

        public long Id { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string UserName { get; set; }
        public List<City> Cities { get; set; } 

    }
}