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
    
    public partial class tbl_firma_durum
    {
        public long durumno { get; set; }
        public System.DateTime tarih { get; set; }
        public string firmakod { get; set; }
        public string durumfirmakod { get; set; }
        public string aciklama { get; set; }
        public string olusturanadisoyadi { get; set; }
        public System.DateTime olusturmatarihi { get; set; }
    
        public virtual tbl_firma tbl_firma { get; set; }
    }
}