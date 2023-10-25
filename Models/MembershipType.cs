using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }

        public byte DureationInMonths { get; set; }

        public short DiscuntRate { get; set; }
    }
}