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
    
    public partial class tbl_maliyet_islem_urun
    {
        public long maliyetislemurunid { get; set; }
        public int maliyetkodu { get; set; }
        public long maliyetislemid { get; set; }
        public string islemkod { get; set; }
        public string urunkod { get; set; }
        public string uruntipkod { get; set; }
        public string birimkod { get; set; }
        public string birimtip { get; set; }
        public bool eniesit { get; set; }
        public bool boyuesit { get; set; }
        public double en { get; set; }
        public double boy { get; set; }
        public double artien { get; set; }
        public double artiboy { get; set; }
        public double artitopen { get; set; }
        public double artitopboy { get; set; }
        public double yogunlukgram { get; set; }
        public double yogunlukadet { get; set; }
        public double yogunlukalan { get; set; }
        public double hammaddefiyat { get; set; }
        public string parabirimi { get; set; }
        public double fiyateurokg { get; set; }
        public double fiyateuroalan { get; set; }
        public double malzemeuretimeni { get; set; }
        public byte urunyyadet { get; set; }
        public byte urunaaadet { get; set; }
        public string olusturanadisoyadi { get; set; }
        public System.DateTime olusturmatarihi { get; set; }
    }
}