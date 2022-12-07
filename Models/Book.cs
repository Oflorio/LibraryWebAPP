﻿namespace LibraryWebAPP.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Isbn { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public decimal? Price { get; set; }

    }
}
