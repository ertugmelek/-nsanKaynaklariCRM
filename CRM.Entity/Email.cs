//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Email
    {
        public int MailID { get; set; }
        public int MusteriID { get; set; }
        public string EmailAdres { get; set; }
    
        public virtual Musteri Musteri { get; set; }
    }
}