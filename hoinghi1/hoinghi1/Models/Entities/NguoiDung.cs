using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebsiteQuanLyHoiNghi.Models.Entities
{
    [Table("NguoiDung")]
    public class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        public string TenDangNhap { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string MatKhau { get; set; } = string.Empty;

        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string HoTen { get; set; } = string.Empty;

        public string SDT { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; } = string.Empty;

        // Bổ sung theo yêu cầu đề tài Hội nghị
        public string CongTy { get; set; } = string.Empty;

        public string ChucVu { get; set; } = string.Empty;

        // Vai trò: Admin hoặc Attendee
        public string VaiTro { get; set; } = "Attendee";

        // Quan hệ: Một người dùng có thể có nhiều đơn đăng ký sự kiện và phiên
        public virtual ICollection<DangKySuKien>? DangKySuKiens { get; set; }
        public virtual ICollection<DangKyPhien>? DangKyPhiens { get; set; }
    }
}