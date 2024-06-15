using Microsoft.AspNetCore.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class Userİnfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="ad alanı zorunlu")]
        public string? Name{ get; set; }

        [Required(ErrorMessage ="telefon alanı zorunlu")]
        public int?Phone { get; set; }
        [Required]
        [EmailAddress]
        public string? Eposta { get; set;}
        [Required]
        public bool? wiilattend { get; set;}
        
    }
    }

