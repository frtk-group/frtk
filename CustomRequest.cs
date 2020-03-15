using System;
using System.ComponentModel.DataAnnotations;

namespace Fartak.Entities.Domain
{
    public class CustomRequest
    {
        public CustomRequest()
        {
            UniqueId = Guid.NewGuid().ToString("D");
        }
        [Key] public int Id { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Mobile { get; set; }
        public string Category { get; set; }
        public string Address { get; set; }
        public string Message { get; set; }
    }
}