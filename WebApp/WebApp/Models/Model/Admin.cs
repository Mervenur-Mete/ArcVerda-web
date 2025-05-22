using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Models.Model
{
    [Table("Admin")]
    public class Admin : BaseEntity
    {

        [Required, StringLength(50, ErrorMessage = "Name can be up to 50 characters long.")]
        public string FullName { get; set; }
        [Required, StringLength(50, ErrorMessage = "Email must be 50 characters or less.")]
        public string Eposta { get; set; }

        [Required, StringLength(50, ErrorMessage = "Role must be 50 characters or less.")]
        public string Yetki { get; set; }
        // yetkiyi enum olarakta tutabiliriz

        public ICollection<AdminLog> AdminLogs { get; set; }
    }

}