using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Models.Model
{
    [Table("UserProject")]
    public class UserProject : BaseEntity
    {

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(50, ErrorMessage = "Full name must be max 50 characters.")]
        public string Fullname { get; set; }

        [StringLength(200)]
        [DisplayName("Image Path")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(50, ErrorMessage = "Title must be max 50 characters.")]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Description must be max 500 characters.")]
        public string Description { get; set; }
        public DateTime UpdatedTime { get; set; } = DateTime.Now;

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }

}