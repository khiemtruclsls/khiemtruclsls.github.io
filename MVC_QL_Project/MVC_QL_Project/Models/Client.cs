using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_QL_Project.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Required]
        public string ClientName { get; set; }

        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string ClientCompany { get; set; }
    }
}