using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Models.Model
{
    [Table("CustomerComment")]
    public class CustomerComment : BaseEntity
    {

        [Required, StringLength(50, ErrorMessage = "Name can be up to 50 characters long.")]
        public string FullName { get; set; }

        [StringLength(50, ErrorMessage = "Title can be up to 50 characters long.")]
        [DisplayName("Comment Title")]
        public string Title { get; set; }

        [Required, StringLength(1000, ErrorMessage = "Comment can be up to 1000 characters long.")]
        [DisplayName("Comment Description")]
        public string Description { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [DisplayName("Rating")]
        public int Point { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }

}