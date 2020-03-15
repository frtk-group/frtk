using System;
using System.ComponentModel.DataAnnotations;

namespace Fartak.Entities.Domain
{
    public class Consult
    {
        public Consult()
        {
            UniqueId = Guid.NewGuid().ToString("D");
        }
        [Key] public int Id { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Mobile { get; set; }
        public bool IsRead { get; set; }
    }
}