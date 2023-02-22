﻿using System;
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
        [Required]
        public string Title { get; set; }
        [Required]
        public ushort Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required] // required inputs
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        public string Notes { get; set; }
        
        // Build Foreign Key Relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
