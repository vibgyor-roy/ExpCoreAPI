using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace ProductAPI.Models
{
    public class User
    {
        [Key]
        public int iD;
        public string Name {get; set;}
        public string eMailID {get; set;}
        public int ID { get => iD; set => iD = value; }
    }
}