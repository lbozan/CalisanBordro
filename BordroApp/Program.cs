using BordroApp.Models;
using BordroApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BordroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Çalışan Bordro ####");

            // Test verileri eklemek için Doldur() metod'unu 1 kereliğine çalıştırın.
            //Doldur();

            Listele();

            Console.ReadLine();
        }


        private static void Listele()
        {
            List<CalisanBordroViewModel> list = new List<CalisanBordroViewModel>();
            using (var db = new BordroContext())
            {
                list.AddRange(from c in db.Calisan
                              join r in db.CalisanMaasRelations on c.Id equals r.CalisanId
                              join m in db.MaasTipi on r.MaasTipiId equals m.Id
                              join z in db.ZamanTipi on r.ZamanTipiId equals z.Id
                              select new CalisanBordroViewModel { Id = c.Id, AdSoyad = $"{c.Ad} {c.Soyad}", TC = c.TC, MaasTipi = m.Tip, Ucreti = (m.Ucret * z.Deger), Deger = z.Deger });
            }

            list?.Select(v => new { v.Id, v.AdSoyad, v.TC })
                 .Distinct()
                 .ToList()
                 .ForEach(v =>
                         {
                             Console.WriteLine($"\n## Id :{v.Id}  Ad Soyad :{v.AdSoyad}  TC :{v.TC}");

                             var calisan = list.Where(x => x.Id == v.Id).ToList();

                             calisan.ForEach(item => { Console.WriteLine($"Çalışma Tipi :{item.Deger} {item.MaasTipi} - Ücreti :{item.Ucreti}"); });
                             Console.WriteLine($"Toplam Ücret :{calisan.Sum(z => z.Ucreti)}");
                         });
        }


        //private static void Doldur()
        //{
        //    using (var db = new BordroContext())
        //    {
        //        var calisan1 = new Calisan { Ad = "dev", Soyad = "labs", TC = "99999988800" };
        //        var calisan2 = new Calisan { Ad = "test", Soyad = "demo", TC = "99999988800" };

        //        var maasTip1 = new MaasTipi() { Tip = "Sabit", Ucret = 1500 };
        //        var maasTip2 = new MaasTipi() { Tip = "Gün", Ucret = 200 };
        //        var maasTip3 = new MaasTipi() { Tip = "Saat", Ucret = 20 };

        //        var zamanTip1 = new ZamanTipi() { Deger = 1 };
        //        var zamanTip2 = new ZamanTipi() { Deger = 2 };
        //        var zamanTip3 = new ZamanTipi() { Deger = 3 };

        //        db.Calisan.Add(calisan1);
        //        db.Calisan.Add(calisan2);

        //        db.MaasTipi.Add(maasTip1);
        //        db.MaasTipi.Add(maasTip2);
        //        db.MaasTipi.Add(maasTip3);

        //        db.ZamanTipi.Add(zamanTip1);
        //        db.ZamanTipi.Add(zamanTip2);
        //        db.ZamanTipi.Add(zamanTip3);

        //        db.CalisanMaasRelations.Add(new CalisanMaasRelations() { CalisanId = calisan1.Id, MaasTipiId = maasTip1.Id, ZamanTipiId = zamanTip1.Id });
        //        db.CalisanMaasRelations.Add(new CalisanMaasRelations() { CalisanId = calisan2.Id, MaasTipiId = maasTip2.Id, ZamanTipiId = zamanTip3.Id });
        //        db.CalisanMaasRelations.Add(new CalisanMaasRelations() { CalisanId = calisan1.Id, MaasTipiId = maasTip3.Id, ZamanTipiId = zamanTip2.Id });

        //        db.SaveChanges();
        //    }
        //}

    }


}
