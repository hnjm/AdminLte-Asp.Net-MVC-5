//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class App_users
    {
        public int user_no { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> Registration_no { get; set; }
    
        public virtual App_registration App_registration { get; set; }
    }
}
