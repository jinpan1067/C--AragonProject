//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AragonClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRefill
    {
        public short PrescriptionID { get; set; }
        public string RefillDate { get; set; }
        public short EmpID { get; set; }
    
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblRx tblRx { get; set; }
    }
}
