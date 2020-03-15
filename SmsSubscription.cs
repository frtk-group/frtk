using System;
using System.ComponentModel.DataAnnotations;

namespace Fartak.Entities.Domain
{
    public class SmsSubscription
    {
        public SmsSubscription()
        {
            UniqueId = Guid.NewGuid().ToString("D");
        }
        [Key] public int Id { get; set; }
        public string UniqueId { get; set; }
        public DateTimeOffset ContactDate { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsRead { get; set; }
    }
}