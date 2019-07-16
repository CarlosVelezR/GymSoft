using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GymSoftApplication.Models
{
    public class UserModel
    {
        [Key]
        public int idUser { get; set; }     
        [Required]  
        [StringLength(20)] 
        public string userName { get; set; }
        [Required]
        [StringLength(25)]
        public string userType { get; set; }
        [Required]
        public DateTime visitCreation { get; set; }
    }
}