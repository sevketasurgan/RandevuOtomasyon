namespace HastahaneRandevuProje
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RandevuModel : DbContext
    {
        
        public RandevuModel()
            : base("name=RandevuModel")
        {
        }
        
     
        public virtual DbSet<randevular> randevulars { get; set; }
        public virtual DbSet<doktorkayit> doktorkayits { get; set; }
        public virtual DbSet<sekreterkayit> sekreterkayits { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<randevular>()
                .Property(e => e.isim)
                .IsUnicode(false);

            modelBuilder.Entity<randevular>()
                .Property(e => e.soyisim)
                .IsUnicode(false);

            modelBuilder.Entity<randevular>()
                .Property(e => e.bolum)
                .IsUnicode(false);

            modelBuilder.Entity<randevular>()
                .Property(e => e.tarih)
                .IsUnicode(false);

            modelBuilder.Entity<randevular>()
                .Property(e => e.saat)
                .IsUnicode(false);

            modelBuilder.Entity<randevular>()
                .Property(e => e.vki)
                .IsUnicode(false);

            modelBuilder.Entity<randevular>()
                .Property(e => e.doktorisim)
                .IsUnicode(false);

            modelBuilder.Entity<randevular>()
                .Property(e => e.kilo)
                .IsUnicode(false);

            modelBuilder.Entity<randevular>()
                .Property(e => e.boy)
                .IsUnicode(false);

            modelBuilder.Entity<randevular>()
                .Property(e => e.yas)
                .IsUnicode(false);

            modelBuilder.Entity<randevular>()
                .Property(e => e.cinsiyet)
                .IsUnicode(false);
            modelBuilder.Entity<randevular>()
                .Property(e => e.value)
                .IsUnicode(false);
            modelBuilder.Entity<doktorkayit>()
                .Property(e => e.fullname)
                .IsUnicode(false);
            modelBuilder.Entity<doktorkayit>()
               .Property(e => e.sifre)
               .IsUnicode(false);
            modelBuilder.Entity<doktorkayit>()
               .Property(e => e.fullname)
               .IsUnicode(false);
            modelBuilder.Entity<doktorkayit>()
               .Property(e => e.kullaniciad)
               .IsUnicode(false);
            modelBuilder.Entity<doktorkayit>()
               .Property(e => e.bolum)
               .IsUnicode(false);
            modelBuilder.Entity<sekreterkayit>()
                .Property(e => e.ad)
                .IsUnicode(false);
            modelBuilder.Entity<sekreterkayit>()
                .Property(e => e.soyad)
                .IsUnicode(false);
            modelBuilder.Entity<sekreterkayit>()
                .Property(e => e.kullaniciad)
                .IsUnicode(false);
            modelBuilder.Entity<sekreterkayit>()
                .Property(e => e.sifre)
                .IsUnicode(false);







        }
    }
}
