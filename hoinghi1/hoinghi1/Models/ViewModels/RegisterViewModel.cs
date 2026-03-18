using System.ComponentModel.DataAnnotations;

namespace WebsiteDatVeRapPhim.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Nhập tên đăng nhập")]
        public string TenDangNhap { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nhập họ tên")]
        public string HoTen { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nhập số điện thoại")]
        public string SDT { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nhập email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; } = string.Empty;
    }
}
