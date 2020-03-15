using System;
using System.ComponentModel.DataAnnotations;

namespace Fartak.Entities.Domain
{
    public class EmailSubscription
    {
        public EmailSubscription()
        {
            UniqueId = Guid.NewGuid().ToString("D");
        }
        [Key] public int Id { get; set; }
        public string UniqueId { get; set; }
        public DateTimeOffset ContactDate { get; set; }
        public string Email { get; set; }
        public bool IsRead { get; set; }
    }
}