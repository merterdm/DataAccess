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
    
    public partial class tbl_siparis
    {
        public int siparisno { get; set; }
        public string urunkod { get; set; }
        public string revizyonkod { get; set; }
        public double siparismiktar { get; set; }
        public string birimkod { get; set; }
        public System.DateTime siparistarih { get; set; }
        public string siparisbirim { get; set; }
        public double siparisfiyat { get; set; }
        public string dovizkod { get; set; }
        public int maliyetkodu { get; set; }
        public string firmakod { get; set; }
        public short firmId { get; set; }
        public double kdv { get; set; }
        public string kisikod { get; set; }
        public string ozelbilgi { get; set; }
        public double bicakfiyat { get; set; }
        public string bdovizkod { get; set; }
        public string bbirim { get; set; }
        public double klisefiyat { get; set; }
        public string kdovizkod { get; set; }
        public short kliseadet { get; set; }
        public bool bfaturaet { get; set; }
        public bool bfaturaedildi { get; set; }
        public bool kfaturaet { get; set; }
        public bool kfaturaedildi { get; set; }
        public double uygulamamiktar { get; set; }
        public bool kontrol_kapat { get; set; }
        public Nullable<System.DateTime> kapattarih { get; set; }
        public bool kontrol_depo { get; set; }
        public bool kontrol_kapat2 { get; set; }
        public double toplamalan { get; set; }
        public double toplamagirlik { get; set; }
        public double toplamadet { get; set; }
        public double toplamteslimmiktar { get; set; }
        public string personelkodu { get; set; }
        public string temsilci { get; set; }
        public bool imalattakip { get; set; }
        public int tramyogunlugu { get; set; }
        public double gelirtutar { get; set; }
        public double gelirtutarklise { get; set; }
        public double gelirtutarbicak { get; set; }
        public double gidertutar { get; set; }
        public double gidertutarkur { get; set; }
        public double maliyetadet { get; set; }
        public double toplamteslim { get; set; }
        public Nullable<System.DateTime> muhtemeltarih { get; set; }
        public Nullable<System.DateTime> planlanantarih { get; set; }
        public bool depodan { get; set; }
        public bool ilkdefa { get; set; }
        public string ilkdefauy { get; set; }
        public bool revizyonvar { get; set; }
        public bool eskifilmat { get; set; }
        public bool revizyonfilmdegil { get; set; }
        public string revizyonnot { get; set; }
        public string irsaliyenot { get; set; }
        public string faturanot { get; set; }
        public string musterisano { get; set; }
        public string onayadres { get; set; }
        public int oncekilot { get; set; }
        public bool iptal { get; set; }
        public bool prova { get; set; }
        public double globalfiyat { get; set; }
        public string yeniurun { get; set; }
        public string urunacildi { get; set; }
        public double satistltutar { get; set; }
        public bool bedelsiz { get; set; }
        public byte satistipi { get; set; }
        public string testtipi { get; set; }
        public short numuneadet { get; set; }
        public double urunalan { get; set; }
        public double sabitkur { get; set; }
        public string grafikpersonel { get; set; }
        public string grafikonay { get; set; }
        public string kardes { get; set; }
        public string siparisurunadi { get; set; }
        public string siparismusterikod { get; set; }
        public double siparistekebadboy { get; set; }
        public double siparistekebaden { get; set; }
        public double siparistekebadyukseklik { get; set; }
        public short siparisyyadet { get; set; }
        public double siparisaabosluk { get; set; }
        public double siparisyybosluk { get; set; }
        public short siparisyybitisikadet { get; set; }
        public double siparisbaskiaabosluk { get; set; }
        public double siparislf { get; set; }
        public double siparisyapistirmapayi { get; set; }
        public double sipariscl { get; set; }
        public string siparisuygulamasekli { get; set; }
        public string siparisholtmelt { get; set; }
        public string siparisperfore { get; set; }
        public string siparisbicakkodu { get; set; }
        public string siparisurunnot { get; set; }
        public bool siparisadettakim { get; set; }
        public short siparistakimmiktar { get; set; }
        public string siparisrulobirim { get; set; }
        public bool siparisadettakim2 { get; set; }
        public short siparistakimmiktar2 { get; set; }
        public double siparisuruneken { get; set; }
        public bool siparisdevamlilik { get; set; }
        public string siparisarsivno { get; set; }
        public string siparisboyayogunluk { get; set; }
        public string sipariskliseno { get; set; }
        public double onaydakibakiye { get; set; }
        public string bakiyedovizkod { get; set; }
        public double onaydakirisk { get; set; }
        public string riskdovizkod { get; set; }
        public string muhasebeonay { get; set; }
        public string muhasebeonaylayan { get; set; }
        public Nullable<System.DateTime> muhasebeonaytarih { get; set; }
        public string yonetimonay { get; set; }
        public string yonetimonaylayan { get; set; }
        public Nullable<System.DateTime> yonetimonaytarih { get; set; }
        public string yonetimonay2 { get; set; }
        public string yonetimonaylayan2 { get; set; }
        public Nullable<System.DateTime> yonetimonaytarih2 { get; set; }
        public string bicakdurum { get; set; }
        public string klisedurum { get; set; }
        public string malzemedurum { get; set; }
        public Nullable<System.DateTime> planlamatermintarihi { get; set; }
        public string carikod { get; set; }
        public Nullable<System.DateTime> planlamakabultarihi { get; set; }
        public double iskontoyuzde { get; set; }
        public Nullable<System.DateTime> kapanistarihi { get; set; }
        public string olusturanadisoyadi { get; set; }
        public System.DateTime olusturmatarihi { get; set; }
    }
}
