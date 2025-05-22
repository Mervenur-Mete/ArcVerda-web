using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Models.Model
{
    [Table("Services")]
    public class Service : BaseEntity
    {
        [Required, StringLength(50, ErrorMessage = "Service title can be up to 50 characters long.")]
        [DisplayName("Service Title")]
        public string ServiceTitle { get; set; }

        [Required, StringLength(500, ErrorMessage = "Description can be up to 500 characters long.")]
        [DisplayName("Service Description")]
        public string Description { get; set; }

        [StringLength(200)]
        [DisplayName("Image Path")]
        public string Image { get; set; }
    }

}