using System;
using System.Collections.Generic;

namespace BestProjectT210.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
