using Microsoft.EntityFrameworkCore;

namespace EfCore_RelatedDataSave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext context = new SqlDbContext();
            #region one-to-one iliskilerde object referansi ile kayit ekleme
            //Dependent Objenin olusturulmasi
            //Address alininAdresi = new Address 
            //{ 
            //    Ulke="TR",
            //    Sehir="Van",
            //    Ilce="Tatvan"

            //};

            ////Principal objenin olusturulmasi 
            //Person ali = new Person
            //{
            //    Adi = "Ali",
            //    Soyadi = "Yilmaz",
            //    Address = alininAdresi
            //};

            //context.Personeller.Add(ali);
            //context.SaveChanges();


            #endregion
            #region one-to-oen iliskilerder object initilaize ile kayit ekleme



            //Principal objenin olusturulmasi 
            //Person ayse = new Person
            //{
            //    Adi = "Ayse",
            //    Soyadi = "Kaya",
            //    Address = new Address
            //    {
            //        Ulke = "TR",
            //        Sehir = "Mus",
            //        Ilce = "Adilcevaz"

            //    }
            //};
            //context.Addresses.Add(adres);
            //context.SaveChanges();
            #region Depented entity direk olarak database'e saklanamaz.

            //Depented entity direk olarak database'e saklanamaz.
            //Asagidaki kod hata verecektir.

            //var adres = new Address
            //{
            //    Ulke = "TR",
            //    Sehir = "Mus",
            //    Ilce = "Adilcevaz"

            //};


            //context.Addresses.Add(adres);
            //context.SaveChanges();

            #endregion
            #endregion


            #region One-To-Many iliskilerde Kayit islemi

            #region 1. Yontem: Principal Entity uzerinden Dependent Entity verisi ekleme
            #region Nesne Referansi uzerinden Ekleme

            //Blog blog = new Blog {Name="Dunya Kupasi Maclari" };
            //blog.Posts.Add(new Post { Baslik="Almanya-Japonya Maci" , Aciklama="Hic Beklenmiyordu "});
            //blog.Posts.Add(new Post { Baslik = "Almanya-Japonya Maci", Aciklama = "Japonlar imkansizi Basardi" });
            //blog.Posts.Add(new Post { Baslik = "Almanya-Japonya Maci", Aciklama = "Japonlar Maç Sonrasi Kendi coplerini Topladilar" });
            //context.Bloglar.Add(blog);
            //context.SaveChanges();
            #endregion
            #region Object Initializer uzerinden ekleme
            //Blog blog = new Blog 
            //{ 
            //    Name = "Blog Yazisi 2" ,
            //    Posts = new List<Post>(){   new Post{Baslik="Blog 2 yorum 1" ,Aciklama="Yorum 1"},
            //                                new Post{Baslik="Blog 2 yorum 2" ,Aciklama="Yorum 2"},
            //                                new Post{Baslik="Blog 2 yorum 3" ,Aciklama="Yorum 3"}
            //                        },
            //};
            //context.Bloglar.Add(blog);
            //context.SaveChanges();


            #endregion
            #endregion


            #region 2. Yontem Dependent Entity Uzerinden Kayit ekleme

            //Post post = new Post()
            //{
            //    Baslik = "Blog 3 Yarim 1",
            //    Aciklama = "Blog 3 icin yorum eklendi",
            //    Blog = new() { Name = "Blog 3 " }
            //};

            //context.Postlar.Add(post);
            //context.SaveChanges();

            #endregion

            #region 3. Yontem Foreign Key uzerinden veri Ekleme

            //Post post = new Post() 
            //{ 
            //    Baslik ="Yorum 3",
            //    Aciklama="Blog 3 icin yorum 3",
            //    BlogId=3

            //};
            //context.Postlar.Add(post);
            //context.SaveChanges();
            #endregion



            #endregion


            #region Many-To-Many kayit ekleme

            //Kitap yuksekMatematik = new Kitap()
            //{
            //    KitapAdi = "Yuksek Matematik",
            //    Yazarlar = new HashSet<Yazar>() { 
            //        new Yazar() { YazarAdi = "Ahmet Karadeniz" } ,
            //        new Yazar() { YazarAdi = "Mehmet Karadeniz" } 

            //    }

            //};

            //context.Kitaplar.Add(yuksekMatematik);
            //context.SaveChanges();

            //Yazar aliveli = new Yazar()
            //{
            //    YazarAdi = "Ali Veli",
            //    Kitaplar = new HashSet<Kitap>() {
            //        new Kitap() { KitapAdi = "Cin Alinin Maceralari" } ,
            //        new Kitap() { KitapAdi = "Cin Ali Tatilde" }

            //    }

            //};

            //context.Yazarlar.Add(aliveli);
            //context.SaveChanges();


            #endregion


            #region Many-To-Many kayit Guncelleme
            // 3 numarali kiabi 1 numarali yazara atamak istedigimizde

            //Kitaba Konumlan
            //Kitap? kitap = context.Kitaplar.Find(3);
            ////Yeni yazara konumlan
            //Yazar? yeniyazar = context.Yazarlar.Find(1);

            ////Eski yazara konumlan
            //Yazar? eskiyazar = context.Yazarlar
            //    .Include(p => p.Kitaplar)
            //    .FirstOrDefault(p => p.Id == 3);
            ////Eski yazardan kitabi kaldir
            //eskiyazar.Kitaplar.Remove(kitap);

            ////kitabi yeniyazara ekle
            //kitap.Yazarlar.Add(yeniyazar);

            //var objects = context.ChangeTracker;

            //context.SaveChanges();

            #endregion


            #region One-To-Many Kayit Guncelleme
            // Blog 3 icin yapilan en son yorum u blog 2 ye aktarin.
            /* 1- Eski Blog'a konumlan
             * 2- Post'a konumlan.
             * 3- Eski Blog'dan Remove Et
             * 4- Yeni Blog'a konumlan 
             * 5- Yeni Blog'a ekle
             */

            //1- Eski Bloga Konumlan

            //Blog? eskiblog=context.Bloglar.Include(p=>p.Posts).FirstOrDefault(p=>p.Id==3);

            ////2.Adim Post'a Konumlan 
            //Post? post = context.Postlar.FirstOrDefault(p => p.Id == 9);

            ////3. Adim 
            //eskiblog.Posts.Remove(post);

            //// 4. Adim 
            //Blog? yeniBlog = context.Bloglar.Find(2);
            //yeniBlog.Posts.Add(post);

            //context.SaveChanges();

            #endregion


            #region Bagimli verilerin iliskisel oldugu ana veriyi guncelleme
            //Dependent Entity'nin Pricipal Entity'sini guncelleme
            // 6 numarali post'u 3 numarali Blog'a atama islemi

            //Post? post = context.Postlar.Find(6);
            //Blog? blog= context.Bloglar.Find(3);

            //post.Blog = blog;

            //context.SaveChanges();


            #endregion


            #region One-ToMany Kayit silme

            //3 Numarali blog'a ait post'lari silme


            Blog? blog = context.Bloglar.Include(p=>p.Posts).FirstOrDefault(p=>p.Id==2);

            context.Bloglar.Remove(blog);

            context.SaveChanges();

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}