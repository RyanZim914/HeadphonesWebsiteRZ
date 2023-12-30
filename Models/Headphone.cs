using System.Xml.Serialization;
using static HeadphonesWebsiteRZ.Models.Rating;
namespace HeadphonesWebsiteRZ.Models
{
    public class Headphone
    {
        public int ItemId { get; set; }
        decimal ItemPrice { get; set; }
        Rating? AverageRating { get; set; }
    }
}
