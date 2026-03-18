namespace WebsiteDatVeRapPhim.Models.ViewModels
{
    public class AdminDashboardVM
    {
        public int TongSoPhim { get; set; }
        public int TongPhongChieu { get; set; }
        public int SuatChieuHomNay { get; set; }
        public int VeDaBan { get; set; }
        public decimal TongDoanhThu { get; set; }

        public List<DoanhThuPhimVM> DoanhThuTheoPhim { get; set; } = new();
        public List<TopPhimVM> Top5Phim { get; set; } = new();
        public List<TyLeLapDayVM> TyLeLapDay { get; set; } = new();
    }

    public class DoanhThuPhimVM
    {
        public string TenPhim { get; set; }
        public decimal DoanhThu { get; set; }
    }

    public class TopPhimVM
    {
        public string TenPhim { get; set; }
        public int SoVe { get; set; }
    }

    public class TyLeLapDayVM
    {
        public string TenPhim { get; set; }
        public string SuatChieu { get; set; }
        public double TyLe { get; set; }
    }
}