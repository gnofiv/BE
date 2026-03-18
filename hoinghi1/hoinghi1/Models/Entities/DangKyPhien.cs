
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebsiteQuanLyHoiNghi.Models.Entities;

public class DangKyPhien
{
    [Key]
    public int MaDangKyPhien { get; set; }
    public int MaNguoiDung { get; set; }
    public int MaPhien { get; set; }

    [ForeignKey("MaNguoiDung")]
    public virtual NguoiDung? NguoiDung { get; set; }
    [ForeignKey("MaPhien")]
    public virtual Phien? Phien { get; set; }
}