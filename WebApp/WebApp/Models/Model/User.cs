using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Models.Model
{
    [Table("User")]
    public class User : BaseEntity
    {
        [Required, StringLength(50, ErrorMessage = "Name can be up to 50 characters long.")]
        public string FullName { get; set; }

        [Required, StringLength(100, ErrorMessage = "Email address must be up to 100 characters long.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [DisplayName("Email Address")]
        public string Eposta { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<UserProject> UserProjects { get; set; }
        public ICollection<UserSubscription> UserSubscriptions { get; set; }
        public ICollection<CustomerComment> CustomerComments { get; set; }
    }

}