//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManager.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users_Table
    {
        public long User_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Employee_ID { get; set; }
        public Nullable<long> Project_ID { get; set; }
        public Nullable<long> Task_ID { get; set; }
    
        public virtual Project_Table Project_Table { get; set; }
        public virtual Task_Table Task_Table { get; set; }
    }
}