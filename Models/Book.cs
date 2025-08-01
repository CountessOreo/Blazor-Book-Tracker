﻿using System.ComponentModel.DataAnnotations;

namespace BookTracker.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        public string? Author { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; }

        [Url(ErrorMessage = "Please enter a valid image URL.")]
        public string? Image { get; set; }
    }
}
