//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestProject.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CountryProvince
    {
        public int COUNTRY_ID { get; set; }
        public int PROVINCE_ID { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Province Province { get; set; }
    }
}
