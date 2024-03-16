using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    //veri tabanında yansıtmak istediğimiz tabloları tutar.
    //DbContext sınıfında miras alacağız.Kütüphanesinide ekledik

    //burası bizim genel yapımız.Veri tabanıyla bu şekilde bağlantı kuruyoruz.
    public class Context : DbContext
    {
        

        //sql bağlantı kodu bu. Bu bizim metodumuz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = KAAN\\SQLEXPRESS ; database=CoreProjeDb ; integrated security=true ; TrustServerCertificate=True");
                                         //SQL den kopyaladım      //kendim verdim bu adı     //yazılacak              //bu hata verdiği durumlarda yaz.
        }

        //bu katman entityLayer içerdiği için oranın classlarını burda tanımlamamız lazım.
        //burda tanımladıklarımız sql de sütun olarak gözükecek.

        //context sınıfına yansıtacağım metotlar
        public DbSet<About> Abouts { get; set; } //sql de gözükecek tablonun isim
        public DbSet<Contact> Contacts { get; set; } //sql de gözükecek tablonun isim
        public DbSet<Experience> Experiences { get; set; } //sql de gözükecek tablonun isim
        public DbSet<Feature> Features { get; set; } //sql de gözükecek tablonun isim
        public DbSet<Message> Messages { get; set; } //sql de gözükecek tablonun isim
        public DbSet<Portfolio> Portfolios { get; set; } //sql de gözükecek tablonun isim
        public DbSet<Service> Services { get; set; } //sql de gözükecek tablonun isim
        public DbSet<Skill> Skills { get; set; } //sql de gözükecek tablonun isim
        public DbSet<SocialMedia> SocialMedias { get; set; } //sql de gözükecek tablonun isim
        public DbSet<Testimonial> Testimonials { get; set; } //sql de gözükecek tablonun isim



    }
}
