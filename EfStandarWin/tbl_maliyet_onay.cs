//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EfStandarWin
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_maliyet_onay
    {
        public long maliyetonayid { get; set; }
        public int maliyetkodu { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
        public double miktar { get; set; }
        public double fiyat { get; set; }
        public string dovizkod { get; set; }
        public string onaylayan { get; set; }
    }
}
