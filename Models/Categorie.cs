namespace HeadphonesWebsiteRZ.Models
{
    public class Categorie
    {
        private int CategorieID;
        string CategorieName { get; set; }
        IFormFile CategoriePhoto { get; set; }
    }
}
