//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMS.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public System.Guid Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
    
        public virtual StudentType StudentType { get; set; }
    }
}
