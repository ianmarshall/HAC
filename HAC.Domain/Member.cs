//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HAC.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public int Id { get; set; }
        public string ForeName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Sex { get; set; }
        public string Access { get; set; }
        public Nullable<int> OldId { get; set; }
        public string MembershipType { get; set; }
        public Nullable<int> MembershipId { get; set; }
    }
}
