using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models.Model
{
    [Table("UserSubscription")]
    public class UserSubscription : BaseEntity
    {

        [Required(ErrorMessage = "Subscription type is required.")]
        [StringLength(50, ErrorMessage = "Subscription type must be max 50 characters.")]
        public string SubscriptionType { get; set; }
        public bool IsAutoRenew { get; set; }// Abonelik otomatik yenilensin mi
        public new DateTime UpdatedDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "End date is required.")]
        public DateTime EndDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }

}