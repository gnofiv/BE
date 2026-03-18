using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using WebsiteQuanLyHoiNghi.Models.Entities;

namespace WebsiteQuanLyHoiNghi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Đăng ký các bảng (Entities) vào Database
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<SuKien> SuKiens { get; set; }
        public DbSet<PhongHop> PhongHops { get; set; }
        public DbSet<Phien> Phiens { get; set; }
        public DbSet<DangKySuKien> DangKySuKiens { get; set; }
        public DbSet<DangKyPhien> DangKyPhiens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình quan hệ n-n hoặc các ràng buộc đặc biệt nếu cần
            // Ví dụ: Một người dùng không thể đăng ký cùng 1 phiên 2 lần
            modelBuilder.Entity<DangKyPhien>()
                .HasIndex(dp => new { dp.MaNguoiDung, dp.MaPhien })
                .IsUnique();

            // Thiết lập xóa dây chuyền: Khi xóa DangKySuKien thì xóa luôn DangKyPhien liên quan
            modelBuilder.Entity<DangKyPhien>()
                .HasOne(dp => dp.NguoiDung)
                .WithMany(u => u.DangKyPhiens)
                .HasForeignKey(dp => dp.MaNguoiDung)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}