namespace WebsiteQuanLyHoiNghi.Models.ViewModels
{
    public class UserProfileViewModel
    {
        public int MaNguoiDung { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CongTy { get; set; } = string.Empty;
        public string ChucVu { get; set; } = string.Empty;

        // Dùng để hiển thị trong danh sách thống kê của Admin
        public string TenSuKienDaDangKy { get; set; } = string.Empty;
    }
}