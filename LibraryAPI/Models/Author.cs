using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace LibraryAPI.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
    }
}