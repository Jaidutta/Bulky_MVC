using System.ComponentModel;

namespace BulkyWeb.Models
{
    public class Category
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        //[DisplayName("Display Order")]  example if asp-for was used
        public int DisplayOrder { get; set; }
    }
}