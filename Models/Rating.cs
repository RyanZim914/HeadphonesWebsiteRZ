using System.ComponentModel.DataAnnotations;

namespace HeadphonesWebsiteRZ.Models
{
    public class Rating
    {
        
        public int RatingId { get; set; }
        [Range(0, 10)]
        public int Rate { get; set; }  //odd is just a half star.
        public string User { get; set; }
        string Comment { get; set; }
    }
}
