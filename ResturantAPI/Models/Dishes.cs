using System.ComponentModel.DataAnnotations;

namespace resturantAPI.Models{
    public class Dishes{
        [Key]
        public int Id{get;set;}
        public string name{get; set;}
        public string description { get; set; }
        public string allergies { get; set; }
        public int Price { get; set; }
        public string ImageSrc { get; set; }
        public string category {get; set;}
    }
}