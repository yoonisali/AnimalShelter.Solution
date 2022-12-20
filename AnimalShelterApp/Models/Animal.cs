using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApp.Models
{
    public class Animal
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public DateTime? start_date {get; set;}
        public string Type {get; set;}
        public string Breed {get; set;}
    }
}