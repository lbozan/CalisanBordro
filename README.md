# Calisan Bordro CASE
.Net Core App and EF 

Bir şirket farklı tipteki çalışanlarına ait maaş bordrolarını, TC, ad, soyad ve maaş bilgisiyle görüntülemek istemektedir. 

Çalışanların maaşları: 

1. Tip çalışanlar sabit maaşlı, 
2. Tip çalışanlar (çalışılan gün sayısı*günlük ücret), 
3. Tip çalışanlar ise sabit maaş + (fazla mesai saati*fazla mesai saat ücreti) kullanılarak hesaplanmaktadır. 

Soru 1: İlgili classları oluşturarak, bu ihtiyacı karşılayacak c# ya da Java dilleriyle uygulamayı yazınız.

Soru 2: İlişkisel veri tabanı tablolarını oluşturunuz.




Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools


Add-Migration InitialCreate
Update-Database
