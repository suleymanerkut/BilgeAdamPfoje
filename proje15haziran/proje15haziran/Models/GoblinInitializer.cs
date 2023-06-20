using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proje15haziran.Models
{
    public class GoblinInitializer:DropCreateDatabaseIfModelChanges<GoblinContext>
    {
        protected override void Seed(GoblinContext context)
        {
            List<Category> Kategoriler = new List<Category>()
            {
                new Category() {CategoryName="Dizi"},
                new Category() {CategoryName="Oyun"},
                new Category() {CategoryName="Film"},
                new Category() {CategoryName="Kitap"},
                new Category() {CategoryName="Müzik"}
            };

            foreach (var item in Kategoriler)
            { context.Kategoriler.Add(item); }
            context.SaveChanges();

            List<Blog> Bloglar = new List<Blog>()
            {
                new Blog() {Baslik="Burası başlık1", Aciklama="Burası açıklama",Tarih=DateTime.Now.AddDays(-20),Anasayfa=true,Onay=true,Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik="Burası başlık2", Aciklama="Burası açıklama",Tarih=DateTime.Now.AddDays(-20),Anasayfa=true,Onay=true,Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik="Burası başlık3", Aciklama="Burası açıklama",Tarih=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Resim="1.jpg",CategoryId=2},
                new Blog() {Baslik="Burası başlık4", Aciklama="Burası açıklama",Tarih=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Resim="1.jpg",CategoryId=2},
                new Blog() {Baslik="Burası başlık5", Aciklama="Burası açıklama",Tarih=DateTime.Now.AddDays(-5),Anasayfa=true,Onay=true,Resim="1.jpg",CategoryId=3},
                new Blog() {Baslik="Burası başlık6", Aciklama="Burası açıklama",Tarih=DateTime.Now.AddDays(-5),Anasayfa=true,Onay=true,Resim="1.jpg",CategoryId=3},
                new Blog() {Baslik="Burası başlık7", Aciklama="Burası açıklama",Tarih=DateTime.Now.AddDays(-3),Anasayfa=true,Onay=true,Resim="1.jpg",CategoryId=4},
                new Blog() {Baslik="Burası başlık8", Aciklama="Burası açıklama",Tarih=DateTime.Now.AddDays(-3),Anasayfa=true,Onay=true,Resim="1.jpg",CategoryId=4},
                new Blog() {Baslik="Burası başlık9", Aciklama="Burası açıklama",Tarih=DateTime.Now.AddDays(-1),Anasayfa=true,Onay=true,Resim="1.jpg",CategoryId=5},
                new Blog() {Baslik="Burası başlık10", Aciklama="Burası açıklama",Tarih=DateTime.Now.AddDays(-1),Anasayfa=true,Onay=true,Resim="1.jpg",CategoryId=5},

            };
            foreach (var item in Bloglar)
            { context.Bloglar.Add(item); }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}