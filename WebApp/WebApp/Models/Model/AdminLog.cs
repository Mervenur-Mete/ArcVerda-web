using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Models.Model
{
    [Table("AdminLog")]
    public class AdminLog : BaseEntity
    {

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(50, ErrorMessage = "Full name must be max 50 characters.")]
        public string FullName { get; set; }

        [StringLength(500, ErrorMessage = "Description must be max 500 characters.")]
        public string Description { get; set; }

        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }
    }

}