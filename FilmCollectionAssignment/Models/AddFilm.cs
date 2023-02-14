using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// variables for the form/ keys for the database
namespace FilmCollectionAssignment.Models
{
    public class AddFilm
    {
        [Key] //primary key
        [Required]
        public int FilmId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public ushort Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        public string Notes { get; set; }

    }
}
