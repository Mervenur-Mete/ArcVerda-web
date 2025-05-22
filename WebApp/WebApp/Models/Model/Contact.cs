using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Models.Model
{
    [Table("Contact")]
    public class Contact : BaseEntity
    {

        [Required, StringLength(100, ErrorMessage = "Email address must be up to 100 characters long.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [DisplayName("Email Address")]
        public string Eposta { get; set; }

        [StringLength(20, ErrorMessage = "Phone number can be up to 20 characters long.")]
        [DisplayName("Phone Number")]
        public string Phone { get; set; }

        [StringLength(500, ErrorMessage = "Address can be up to 500 characters long.")]
        [DisplayName("Address")]
        public string Address { get; set; }

        [StringLength(200)]
        public string Whatsapp { get; set; }

        [StringLength(200)]
        public string Instagram { get; set; }

    }

}