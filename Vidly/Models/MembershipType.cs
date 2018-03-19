using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        //Membership Id
        public byte Id { get; set; }

        //Fee for the Sign-Up
        public short SignUpFee { get; set; }

        //Duration of membership
        public byte DurationInMonths { get; set; }

        //Discount Rate for the membership
        public byte DiscountRate { get; set; }
    }
}