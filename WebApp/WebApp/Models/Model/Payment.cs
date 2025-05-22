using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Models.Model
{
    [Table("Payment")]
    public class Payment : BaseEntity
    {
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Payment date is required.")]
        public DateTime PaymentDate { get; set; }

        [Required(ErrorMessage = "Payment method is required.")]
        [StringLength(50, ErrorMessage = "Payment method must be max 50 characters.")]
        public string PaymentMethod { get; set; }//enum

        [Required(ErrorMessage = "Payment status is required.")]
        [StringLength(50, ErrorMessage = "Payment status must be max 50 characters.")]
        public string PaymentStatus { get; set; }//enum

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }

}