using System;
using System.Collections.Generic;

#nullable disable

namespace ThreeDeePrintingHub.Models
{
    public partial class SecurityRole
    {
        public SecurityRole()
        {
            Members = new HashSet<Member>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
