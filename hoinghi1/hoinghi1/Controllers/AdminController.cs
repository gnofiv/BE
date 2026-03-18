using Microsoft.AspNetCore.Mvc;
using WebsiteQuanLyHoiNghi.Data;

[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public AdminController(ApplicationDbContext context) { _context = context; }

    // GET: api/Admin/Statistics - Thống kê doanh thu
    [HttpGet("Statistics")]
    public async Task<IActionResult> GetStatistics()
    {
        var report = await _context.SuKiens.Select(e => new {
            EventName = e.TenSuKien,
            TotalAttendees = e.DanhSachDangKy.Count(d => d.TrangThai == "Đã đăng ký"),
            Revenue = e.DanhSachDangKy.Count(d => d.TrangThai == "Đã đăng ký") * e.PhiThamGia
        }).ToListAsync();

        return Ok(report);
    }
}