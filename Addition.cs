using System;
using System.ComponentModel.DataAnnotations;

namespace Fartak.Entities.Domain
{
    public class Addition
    {
        public Addition()
        {
            UniqueId = Guid.NewGuid().ToString("D");
        }
        [Key] public int Id { get; set; }
        public string UniqueId { get; set; }
        public DateTimeOffset LastModified { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public double ViewCount { get; set; }
        public bool IsEnabled { get; set; }
    }
}