namespace WebsiteQuanLyHoiNghi.Models.ViewModels
{
    public class RoomViewModel
    {
        public int MaPhong { get; set; }
        public string TenPhong { get; set; } = string.Empty;
        public int SucChua { get; set; }

        // Thêm thuộc tính này để Admin biết phòng có đang trống hay không
        public int SoPhienDangDienRa { get; set; }
    }
}