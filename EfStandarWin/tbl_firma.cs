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
    
    public partial class tbl_firma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_firma()
        {
            this.tbl_firma_durum = new HashSet<tbl_firma_durum>();
            this.tbl_firma_firma = new HashSet<tbl_firma_firma>();
            this.tbl_firma_gorusmeler = new HashSet<tbl_firma_gorusmeler>();
            this.tbl_firma_kontakt = new HashSet<tbl_firma_kontakt>();
            this.tbl_firma_personel = new HashSet<tbl_firma_personel>();
            this.tbl_firma_teslimat = new HashSet<tbl_firma_teslimat>();
        }
    
        public string tip { get; set; }
        public string statu { get; set; }
        public string firmakod { get; set; }
        public string ozelkod { get; set; }
        public string kisaad { get; set; }
        public string ticariad { get; set; }
        public string faturaadres1 { get; set; }
        public string faturaadres2 { get; set; }
        public string postakod { get; set; }
        public string ilcekod { get; set; }
        public string ilkod { get; set; }
        public string ulkekod { get; set; }
        public string telefon1 { get; set; }
        public string telefon2 { get; set; }
        public string faks1 { get; set; }
        public string faks2 { get; set; }
        public string mail { get; set; }
        public string web { get; set; }
        public string muhasebekod { get; set; }
        public string muhasebekodsatis { get; set; }
        public string sektorkod { get; set; }
        public string sektoraltkod { get; set; }
        public string grupkod { get; set; }
        public string vergidairesi { get; set; }
        public string vergino { get; set; }
        public string odemesekli { get; set; }
        public string personelkodu { get; set; }
        public string personelkodu2 { get; set; }
        public string grafikperskod { get; set; }
        public double risklimiti { get; set; }
        public string parabirimi { get; set; }
        public string parabirimicari { get; set; }
        public string durumfirmakod { get; set; }
        public Nullable<System.DateTime> sonaktiftarih { get; set; }
        public string ozelnot { get; set; }
        public string irsaliyenot { get; set; }
        public string faturanot { get; set; }
        public bool istihbaratonay { get; set; }
        public string istihbaratnot { get; set; }
        public string istihbaratpersonelkod { get; set; }
        public string tckimlikno { get; set; }
        public bool sorunlu { get; set; }
        public string sorunnot { get; set; }
        public double valor { get; set; }
        public string odemekod { get; set; }
        public string sevkiyatkod { get; set; }
        public short sevklimit { get; set; }
        public short kalitefiyat { get; set; }
        public short kaliteiletisim { get; set; }
        public Nullable<System.DateTime> ilksiparistarihi { get; set; }
        public string ilksiparispersonel { get; set; }
        public Nullable<System.DateTime> sonsiparistarihi { get; set; }
        public Nullable<System.DateTime> soniletisimtarihi { get; set; }
        public string faturatipi { get; set; }
        public double sabitkur { get; set; }
        public byte yuvarlama { get; set; }
        public string ek1 { get; set; }
        public string ek2 { get; set; }
        public string ek3 { get; set; }
        public string ek4 { get; set; }
        public string olusturanadisoyadi { get; set; }
        public System.DateTime olusturmatarihi { get; set; }
        public Nullable<int> sekId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_firma_durum> tbl_firma_durum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_firma_firma> tbl_firma_firma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_firma_gorusmeler> tbl_firma_gorusmeler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_firma_kontakt> tbl_firma_kontakt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_firma_personel> tbl_firma_personel { get; set; }
        public virtual tbl_sektor tbl_sektor { get; set; }
        public virtual tbl_ulke tbl_ulke { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_firma_teslimat> tbl_firma_teslimat { get; set; }
    }
}
