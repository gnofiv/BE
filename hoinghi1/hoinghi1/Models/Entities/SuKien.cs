using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebsiteQuanLyHoiNghi.Models.Entities
{
    [Table("SuKien")]
    public class SuKien
    {
        [Key]
        public int MaSuKien { get; set; }

        [Required(ErrorMessage = "Tên sự kiện là bắt buộc")]
        [StringLength(250)]
        public string TenSuKien { get; set; } = string.Empty;

        public string? MoTa { get; set; }

        [Required(ErrorMessage = "Địa điểm không được để trống")]
        public string DiaDiem { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime NgayBatDau { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime NgayKetThuc { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Số chỗ tối đa phải lớn hơn 0")]
        public int SoChoToiDa { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Phí tham gia không được là số âm")]
        public decimal PhiThamGia { get; set; }

        public string? HinhAnh { get; set; } // Lưu đường dẫn ảnh banner sự kiện

        // --- Navigation Properties ---

        // Một sự kiện có nhiều phiên (Sessions)
        public virtual ICollection<Phien>? DanhSachPhien { get; set; }

        // Một sự kiện có nhiều người đăng ký
        public virtual ICollection<DangKySuKien>? DanhSachDangKy { get; set; }
    }
}