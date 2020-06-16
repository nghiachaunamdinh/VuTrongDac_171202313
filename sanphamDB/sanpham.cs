namespace sanphamDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class sanpham : DbContext
    {
        public sanpham()
            : base("name=sanpham")
        {
        }

        public virtual DbSet<CAULACBO> CAULACBOes { get; set; }
        public virtual DbSet<CAUTHU> CAUTHUs { get; set; }
        public virtual DbSet<HUANLUYENVIEN> HUANLUYENVIENs { get; set; }
        public virtual DbSet<SANVANDONG> SANVANDONGs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TRANDAU> TRANDAUs { get; set; }
        public virtual DbSet<TRANDAU_CAUTHU> TRANDAU_CAUTHU { get; set; }
        public virtual DbSet<TRANDAU_GHIBAN> TRANDAU_GHIBAN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CAULACBO>()
                .Property(e => e.CauLacBoID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAULACBO>()
                .Property(e => e.TenGoi)
                .IsUnicode(false);

            modelBuilder.Entity<CAULACBO>()
                .Property(e => e.SanVanDongID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAULACBO>()
                .Property(e => e.HuanLuyenVienID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAULACBO>()
                .HasMany(e => e.TRANDAUs)
                .WithOptional(e => e.CAULACBO)
                .HasForeignKey(e => e.CLBKhach);

            modelBuilder.Entity<CAULACBO>()
                .HasMany(e => e.TRANDAUs1)
                .WithOptional(e => e.CAULACBO1)
                .HasForeignKey(e => e.CLBNha);

            modelBuilder.Entity<CAUTHU>()
                .Property(e => e.CauThuID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU>()
                .Property(e => e.CauLacBoID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU>()
                .Property(e => e.ViTri)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU>()
                .Property(e => e.QuocTich)
                .IsUnicode(false);

            modelBuilder.Entity<CAUTHU>()
                .Property(e => e.SoAo)
                .IsFixedLength();

            modelBuilder.Entity<CAUTHU>()
                .HasMany(e => e.TRANDAU_CAUTHU)
                .WithRequired(e => e.CAUTHU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HUANLUYENVIEN>()
                .Property(e => e.HuanLuyenVienID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SANVANDONG>()
                .Property(e => e.SanVanDongID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SANVANDONG>()
                .Property(e => e.ThanhPho)
                .IsFixedLength();

            modelBuilder.Entity<TRANDAU>()
                .Property(e => e.TranDauID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRANDAU>()
                .Property(e => e.CLBKhach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRANDAU>()
                .Property(e => e.CLBNha)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRANDAU>()
                .Property(e => e.SanVanDongID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRANDAU>()
                .HasMany(e => e.TRANDAU_CAUTHU)
                .WithRequired(e => e.TRANDAU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRANDAU_CAUTHU>()
                .Property(e => e.TranDauID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRANDAU_CAUTHU>()
                .Property(e => e.CauThuID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRANDAU_CAUTHU>()
                .Property(e => e.PhamLoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRANDAU_GHIBAN>()
                .Property(e => e.GhiBanID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRANDAU_GHIBAN>()
                .Property(e => e.TranDauID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRANDAU_GHIBAN>()
                .Property(e => e.CauLacBoID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRANDAU_GHIBAN>()
                .Property(e => e.CauThuID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
