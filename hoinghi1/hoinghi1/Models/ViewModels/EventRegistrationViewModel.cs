namespace WebsiteQuanLyHoiNghi.Models.ViewModels
{
    public class EventRegistrationViewModel
    {
        public int MaDangKy { get; set; }
        public string TenSuKien { get; set; } = string.Empty;
        public DateTime NgayBatDauSuKien { get; set; }
        public DateTime NgayDangKy { get; set; }
        public string TrangThai { get; set; } = string.Empty;

        // Logic kiểm tra để hiển thị nút Hủy trên giao diện (View)
        // Chỉ cho phép hủy nếu Ngày bắt đầu - Hôm nay >= 2
        public bool CoTheHuy => (NgayBatDauSuKien - DateTime.Now).TotalDays >= 2;
    }
}