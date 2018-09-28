using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace LibraryAPI.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string BookName { get; set; }
    }
}