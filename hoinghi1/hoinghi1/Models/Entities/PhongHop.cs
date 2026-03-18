using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebsiteQuanLyHoiNghi.Models.Entities
{
    [Table("PhongHop")]
    public class PhongHop
    {
        [Key]
        public int MaPhong { get; set; }

        [Required(ErrorMessage = "Tên phòng không được để trống")]
        [StringLength(100)]
        [Display(Name = "Tên phòng họp")]
        public string TenPhong { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập sức chứa của phòng")]
        [Range(1, 1000, ErrorMessage = "Sức chứa phải từ 1 đến 1000 người")]
        [Display(Name = "Sức chứa (người)")]
        public int SucChua { get; set; }

        // --- Navigation Properties (Mối quan hệ) ---

        // Một phòng họp có thể tổ chức nhiều Phiên (Sessions) khác nhau
        public virtual ICollection<Phien>? Phiens { get; set; }
    }
}