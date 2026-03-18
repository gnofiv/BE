using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebsiteQuanLyHoiNghi.Data;
using WebsiteQuanLyHoiNghi.Models.Entities;

namespace WebsiteQuanLyHoiNghi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AttendeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Attendee/Events - Xem danh sách sự kiện
        [HttpGet("Events")]
        public async Task<ActionResult<IEnumerable<SuKien>>> GetEvents()
        {
            return await _context.SuKiens.ToListAsync();
        }

        // POST: api/Attendee/RegisterEvent - Đăng ký sự kiện
        [HttpPost("RegisterEvent")]
        public async Task<IActionResult> RegisterEvent(int userId, int eventId)
        {
            // 1. Kiểm tra sự kiện tồn tại và còn chỗ không
            var ev = await _context.SuKiens.FindAsync(eventId);
            if (ev == null) return NotFound("Sự kiện không tồn tại");

            int registeredCount = await _context.DangKySuKiens.CountAsync(d => d.MaSuKien == eventId && d.TrangThai == "Đã đăng ký");
            if (registeredCount >= ev.SoChoToiDa) return BadRequest("Sự kiện đã hết chỗ");

            // 2. Lưu đăng ký
            var reg = new DangKySuKien
            {
                MaNguoiDung = userId,
                MaSuKien = eventId,
                NgayDangKy = DateTime.Now,
                TrangThai = "Đã đăng ký"
            };
            _context.DangKySuKiens.Add(reg);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Đăng ký thành công", registrationId = reg.MaDangKy });
        }
    }
}