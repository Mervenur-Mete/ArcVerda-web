using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models.Model
{
    [Table("SubscriptionPlans")]
    public class SubscriptionPlans : BaseEntity
    {

        [Required(ErrorMessage = "Plan name is required.")]
        [StringLength(50, ErrorMessage = "Plan name must be max 50 characters.")]
        public string PlanName { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Duration is required.")]
        [StringLength(50, ErrorMessage = "Duration must be max 50 characters.")]
        public string Duration { get; set; } // plan süresi
    }

}