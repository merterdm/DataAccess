using EfCoreQuery.Entities;

namespace EfCoreQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();

            #region Tablolarda Sorgulama

            #region Standart Sorgulama 

            // Method Syntax

            //var employees = context.Employees;
            //employees.ToList();

            //// Query Syntax 
            //// Burasi Sorguyu hazirlar
            //var sonuc = from emp in context.Employees select emp;


            // ToList ise olusan sorguyu database'de calistirir
            //sonuc.ToList().ForEach(p=>Console.WriteLine(p.FirstName + "  " + p.LastName));

            //foreach ( var emp in employees)
            //{
            //    Console.WriteLine(emp.FirstName + "  " + emp.LastName);

            //}
            #endregion


            #region Where Sarti

            //Method Yontemi 

            //var sonuclar = context.Employees.Where(p => p.FirstName.Contains("a"));
            // var sonuclar = context.Employees.Where(p => p.FirstName.Contains("a") && p.BirthDate.Value.Year>=1960);
            //Console.WriteLine("Bir Harf Giriniz");
            //var harf = Console.ReadLine();


            //sonuclar.Where(p => p.FirstName.Contains("a"));
            //Console.WriteLine("Bir Yil Giriniz");
            //var yil = Console.ReadLine();
            //sonuclar.Where(p => p.BirthDate.Value.Year >= int.Parse(yil));


            //Query Yontemi

            //var sonuc2 = from emp in context.Employees
            //             where emp.FirstName.Contains("a") && emp.BirthDate.Value.Year>=1960
            //             select emp;



            //foreach (var p in sonuc2.ToList())
            //{
            //    global::System.Console.WriteLine(p.FirstName + " "+ p.LastName);
            //}
            #endregion


            #region OrderBy
            //Normal Order by
            //var sonuclar = context.Employees.Where(p => p.FirstName.Contains("a")).OrderBy(p => p.FirstName).ToList(); 
            //// Birden Fazla Kolona gore order by calismasi
            //var sonuclar2 = context.Employees.Where(p => p.FirstName.Contains("a")).OrderBy(p => p.FirstName).ThenBy(p => p.EmployeeId).ToList();

            //Query Snytax


            //var employees = from emp in context.Employees
            //                orderby emp.FirstName , emp.EmployeeId
            //                select emp;

            //foreach (var p in employees.ToList())
            //{
            //    Console.WriteLine(p.EmployeeId + " " +p.FirstName + " " + p.LastName );
            //}
            #endregion
            #region  OrderByDescending

            //Metod Yontemi
            //var sonuclar = context.Employees.Where(p => p.FirstName.Contains("a")).OrderByDescending(p => p.LastName).ToList();
            //// Birden Fazla Kolona gore order by calismasi
            //var sonuclar2 = context.Employees.Where(p => p.FirstName.Contains("a")).OrderBy(p => p.FirstName).ThenBy(p => p.EmployeeId).ToList();

            //Query Snytax


            //var employees = from emp in context.Employees
            //                orderby emp.FirstName descending
            //                select emp;

            //foreach (var p in employees.ToList())
            //{
            //    Console.WriteLine(p.EmployeeId + " " + p.FirstName + " " + p.LastName);
            //}
            #endregion


            #region  Tekil veri Getiren Sorgulama Fonksiyonlari
            // Yapilan sorguda sadece bir tek verinin gelmesini istiyorsak Single yada SingleOrDefault Metodlari kullanilir

            #region Single , SingeOrDefault
            //Single yada SingleAsyn metodlari Egerki sorgu sonucunda birden fazla kayit geliyorsa yada hic gelmiyorsa hata firlatir.
            //SingleOrDefault Eger Sorgu neticesinde birden fazla kayit gelirse hata firlatir. Hiz Kayit gelmez ise null deger geri doner
            //try
            //{
            //    var sonuc = context.Employees.Where(p => p.EmployeeId==1).Single();
            //    var sonuc2 = context.Employees.Where(p => p.EmployeeId==45).SingleOrDefault();
            //    global::System.Console.WriteLine(sonuc.FirstName+ " " + sonuc.LastName);
            //}
            //catch (Exception ex)
            //{
            //    global::System.Console.WriteLine(ex.Message);
            //}

            #endregion



            #region First Ve FirstOrDefult
            // Sorguda ki verilerin ilkini getirir. Ger Kayit Gelmiyorsa hata firlatir



            //try
            //{

            //    //Bu sorgu duzgun calisir
            //    var sonuc = context.Employees.First(p => p.EmployeeId == 1);
            //    global::System.Console.WriteLine(sonuc.FirstName + " " + sonuc.LastName);

            //    //Burasi Hata Firlatacaktir
            //    //var sonuc2 = context.Employees.First(p => p.EmployeeId == 100);
            //    //global::System.Console.WriteLine(sonuc2.FirstName + " " + sonuc2.LastName);
            //    var sonuc3 = context.Employees.FirstOrDefault(p => p.EmployeeId>5);
            //    global::System.Console.WriteLine(sonuc3.FirstName + " " + sonuc3.LastName);

            //}
            //catch (Exception ex)
            //{
            //    global::System.Console.WriteLine(ex.Message);
            //}
            #endregion


            #region Find 
            // Find metodu primary key kolonuna gore arama yapar . Dolayisi ile veriye daha hizli erisir.

            //var sonuc = context.Employees.Find(3);
            //Console.WriteLine(sonuc.FirstName + " " + sonuc.LastName);

            #region Composite PrimaryKey oldugunda ne yapar ?
            //var sonuc = context.Employees.Find(3,5);
            //Console.WriteLine(sonuc.FirstName + " " + sonuc.LastName);

            #endregion

            #endregion


            #region Last , LastOrDefault
            // Sorguda ki verilerin sonuncusunu getirir. Ger Kayit Gelmiyorsa hata firlatir
            // Bu sorguda OrderBy Kullanilmasi Zorunludur

            //var result  = context.Employees.OrderBy(p=>p.EmployeeId).Last(p => p.EmployeeId >= 3);
            //Console.WriteLine(result.FirstName + " " + result.LastName);

            //var result2 = context.Employees.OrderBy(p => p.EmployeeId).LastOrDefault(p => p.EmployeeId >= 3);
            //Console.WriteLine(result2.FirstName + " " + result2.LastName);
            #endregion


            #endregion



            #endregion




            #region Diger Sorgulama Fonksiyonlari


            #region Count
            // Olusturulan sorgularin execute edilmesi neticesinde kac adet satirin elde edilecegini sayisal olarak (int) bize veren fonksiyondur

            //var sonuc = (context.Employees.ToList()).Count();
            //Console.WriteLine($"Employee Tablosunda {sonuc} adet kayit vardir");
            #endregion
            #region LongCount
            //var sonuc = (context.Employees.ToList()).LongCount();
            //Console.WriteLine($"Employee Tablosunda {sonuc} adet kayit vardir");
            #endregion

            #region Any 
            // Sorgu sonucunda verinin gelip gelmedigini bool turunden geri donen fonksiyondur

            //var sonuc = (context.Employees.Where(p=>p.EmployeeId>10).ToList()).Any();
            //Console.WriteLine($"Employee Tablosunda  kayit vardir: {sonuc} ");

            #endregion


            #region Max,Min
            //Max verilen kolondaki max degerini getirir.
            //var sonuc = context.Products.Max(p => p.UnitPrice);
            //Console.WriteLine($"Urunler  Tablosundaki en yuksek fiyat: {sonuc} ");
            //var sonuc2 = context.Products.Min(p => p.UnitPrice);
            //Console.WriteLine($"Urunler  Tablosundaki en dusuk fiyat: {sonuc2} ");

            #endregion


            #region Distinct 
            // Sorgudaki kayitlari tekillestirir
            //var sonuc = context.Products.Distinct().ToList();
            //Console.WriteLine($"Urunler  Tablosundaki en yuksek fiyat: {sonuc} ");




            #endregion

            #region Sum
            // Vermis oldugumuz sayisal property'nin toplamini alir

            //var sonuc = context.Products.Sum(p => p.UnitPrice);
            //Console.WriteLine($"Urunler  Tablosundaki  toplam fiyat: {sonuc} ");

            #endregion


            #region Avarage
            // Vermis oldugumuz sayisal property'nin ortalamasini alir

            //var sonuc = context.Products.Average(p => p.UnitPrice);
            //Console.WriteLine($"Urunler  Tablosundaki  fiyat ortalamasi: {sonuc} ");

            #endregion

            #region Contains 

            //// Like '% %' sorgusu olusturmaya yarar
            // context.Products
            //    .Where(p => p.ProductName.Contains("a"))
            //    .ToList()
            //    .ForEach(p=>Console.WriteLine(p.ProductName + " "+p.UnitPrice));

            //Console.WriteLine($"Urunler  Tablosundaki  toplam fiyat: {sonuc} ");


            #endregion

            #region StartWith , EndWith

            //// Like '% %' sorgusu olusturmaya yarar
            context.Products
               .Where(p => p.ProductName.StartsWith("a"))
               .ToList()
               .ForEach(p => Console.WriteLine(p.ProductName + " " + p.UnitPrice));
            Console.WriteLine("*******************************");
            context.Products
               .Where(p => p.ProductName.EndsWith("a"))
               .ToList()
               .ForEach(p => Console.WriteLine(p.ProductName + " " + p.UnitPrice));


            #endregion


            #region Select 
            // Select Metodu Generate edilecek sorgunun cekilecek kolonlarini ayarlamamiza yarar
            // Tek Kolon secilecekse 
            //var urunler = context.Products.Select(p => p.ProductName).ToList();


            // Birden fazla kolon secilecek ise
            //context.Products
            //    .Select(p => new { p.ProductId,p.ProductName,p.UnitPrice})
            //    .ToList()
            //    .ForEach(p=>Console.WriteLine(p.ProductId+ " "+ p.ProductName + " "+p.UnitPrice));


            #endregion


            #region Group by 
            // Gruplama yapmaya yarar

            //Metod Syntax

            //var urunler = context.Products
            //    .GroupBy(p => p.CategoryId)
            //    .Select(group => new
            //    { 
            //        CategoriId=group.Key,
            //        Count=group.Count(),

            //    }
            //    ).ToList();
            //Console.Clear();
            //foreach ( var item in urunler ) 
            //{
            //    global::System.Console.WriteLine(item.CategoriId + " " + item.Count);
            //}

            //Query Syntax

            var data = (from urun in context.Products
                       group urun by urun.CategoryId
                       into @group
                       select new
                       {
                           CategoryId=@group.Key,
                           Adet=@group.Count(),
                       }).ToList();

            foreach (var item in data)
            {
                global::System.Console.WriteLine(item.CategoryId+ " " + item.Adet);
            }

            #endregion

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}