namespace WebsiteQuanLyHoiNghi.Models.ViewModels
{
    public class EventIndexViewModel
    {
        public int MaSuKien { get; set; }
        public string TenSuKien { get; set; } = string.Empty;
        public string DiaDiem { get; set; } = string.Empty;
        public DateTime NgayBatDau { get; set; }
        public decimal PhiThamGia { get; set; }
        public string? HinhAnh { get; set; }
        public int SoChoConTrong { get; set; } // Tính toán: SoChoToiDa - SoNguoiDaDangKy
    }
}