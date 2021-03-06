﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EComm_Project.Models
{
    public class Customer
    {
        [DisplayName("Customer ID")]
        public int CustomerId { get; set; }

        [DisplayName("First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(70)]
        public string Address { get; set; }

        [DisplayName("Phone Number")]
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public List<Order> Orders { get; set; }

        public List<CreditCard> CreditCards { get; set; }
    }
}
