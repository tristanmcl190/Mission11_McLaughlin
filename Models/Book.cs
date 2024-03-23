using System.ComponentModel.DataAnnotations;

namespace Mission11_McLaughlin.Models
{
    public class Book
    {
        public int BookID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        //[RegularExpression(@"^\d{3}-\d{10}$", ErrorMessage = "Invalid ISBN format. Please use ###-########## format.")]
        public string ISBN { get; set; }

        public string Classification { get; set; }

        public string Category { get; set; }

        public int? PageCount { get; set; }

        //[RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Invalid price format. Please use #.## format.")]
        public float? Price { get; set; }
    }
}
