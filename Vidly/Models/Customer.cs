using System;
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
        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]        
        public string Name { get; set; }

        //Is Subscribed to the monthly News Letter
        [Display(Name= "Subscribed to News Letter ?")]
        public bool IsSubscribedToNewsLetter { get; set; }

        //type of membership        
        public MembershipType MembershipType { get; set; }

        //This will be referenced as a foreign key
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        //Date of birth of the Customer.
        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }


    }
}