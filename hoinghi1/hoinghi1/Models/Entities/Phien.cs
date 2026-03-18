using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebsiteQuanLyHoiNghi.Models.Entities
{
    [Table("Phien")]
    public class Phien
    {
        [Key]
        public int MaPhien { get; set; }

        [Required]
        public int MaSuKien { get; set; }

        [Required]
        public string TênPhiên { get; set; } = string.Empty;

        public string? MoTa { get; set; }

        [Required]
        public int MaPhong { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Ngay { get; set; }

        [Required]
        public TimeSpan GioBatDau { get; set; }

        [Required]
        public TimeSpan GioKetThuc { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Số chỗ tối đa phải lớn hơn 0")]
        public int SoChoToiDa { get; set; }

        // --- Liên kết (Navigation Properties) ---

        [ForeignKey("MaSuKien")]
        public virtual SuKien? SuKien { get; set; }

        [ForeignKey("MaPhong")]
        public virtual PhongHop? PhongHop { get; set; }

        // Danh sách đăng ký của phiên này
        public virtual ICollection<DangKyPhien>? DangKyPhiens { get; set; }
    }
}