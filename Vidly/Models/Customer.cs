﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        //Customer's Id
        public int Id { get; set; }

        //Customer's Name
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //Is Subscribed to the monthly News Letter
        public bool IsSubscribedToNewsLetter { get; set; }

        //type of membership
        public MembershipType MembershipType { get; set; }

        //This will be referenced as a foreign key
        public byte MembershipTypeId { get; set; }

        //Date of birth of the Customer.
        public DateTime? DateOfBirth { get; set; }


    }
}