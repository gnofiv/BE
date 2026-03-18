using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebsiteQuanLyHoiNghi.Models.Entities
{
    [Table("DangKySuKien")]
    public class DangKySuKien
    {
        [Key]
        public int MaDangKy { get; set; }

        [Required]
        public int MaNguoiDung { get; set; }

        [Required]
        public int MaSuKien { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime NgayDangKy { get; set; } = DateTime.Now;

        /// <summary>
        /// Trạng thái: "Đã đăng ký" hoặc "Đã hủy"
        /// </summary>
        [Required]
        public string TrangThai { get; set; } = "Đã đăng ký";

        // --- Navigation Properties (Liên kết thực thể) ---

        [ForeignKey("MaNguoiDung")]
        public virtual NguoiDung? NguoiDung { get; set; }

        [ForeignKey("MaSuKien")]
        public virtual SuKien? SuKien { get; set; }

        // Một đơn đăng ký sự kiện có thể dẫn đến nhiều đăng ký phiên bên trong
        public virtual ICollection<DangKyPhien>? DanhSachDangKyPhien { get; set; }
    }
}