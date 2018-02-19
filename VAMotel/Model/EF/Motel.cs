namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Motel : DbContext
    {
        public Motel()
            : base("name=Motel")
        {
        }

        public virtual DbSet<BaiViet> BaiViets { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<KhuTro> KhuTroes { get; set; }
        public virtual DbSet<LichSuThueNha> LichSuThueNhas { get; set; }
        public virtual DbSet<PhongTro> PhongTroes { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaiViet>()
                .Property(e => e.hinh_anh)
                .IsUnicode(false);

            modelBuilder.Entity<BaiViet>()
                .Property(e => e.nguoi_tao)
                .IsUnicode(false);

            modelBuilder.Entity<DanhMuc>()
                .HasMany(e => e.BaiViets)
                .WithOptional(e => e.DanhMuc)
                .HasForeignKey(e => e.ma_danh_muc);

            modelBuilder.Entity<KhuTro>()
                .Property(e => e.chu_tro)
                .IsUnicode(false);

            modelBuilder.Entity<KhuTro>()
                .HasMany(e => e.PhongTroes)
                .WithOptional(e => e.KhuTro)
                .HasForeignKey(e => e.ma_khu_tro);

            modelBuilder.Entity<LichSuThueNha>()
                .Property(e => e.nguoi_thue)
                .IsUnicode(false);

            modelBuilder.Entity<LichSuThueNha>()
                .Property(e => e.cmtnd)
                .IsUnicode(false);

            modelBuilder.Entity<PhongTro>()
                .Property(e => e.nguoi_thue)
                .IsUnicode(false);

            modelBuilder.Entity<PhongTro>()
                .Property(e => e.cmtnd)
                .IsUnicode(false);

            modelBuilder.Entity<PhongTro>()
                .HasMany(e => e.LichSuThueNhas)
                .WithOptional(e => e.PhongTro)
                .HasForeignKey(e => e.ma_phong);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.tai_khoan)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.mat_khau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.ten)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.so_dien_thoai)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.BaiViets)
                .WithOptional(e => e.TaiKhoan)
                .HasForeignKey(e => e.nguoi_tao);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.KhuTroes)
                .WithOptional(e => e.TaiKhoan)
                .HasForeignKey(e => e.chu_tro);
        }
    }
}
