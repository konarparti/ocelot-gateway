﻿namespace ocelot_api.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime LastUpdate { get; set; }
        public int WriterId { get; set; }
    }
}
