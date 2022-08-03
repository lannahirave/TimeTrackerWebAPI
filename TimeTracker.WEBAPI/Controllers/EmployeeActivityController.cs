using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeTracker.BLL.Services.Abstract;

namespace TimeTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeActivityController : ControllerBase
    {
        private readonly EmployeeActivityBaseService _context;

        public EmployeeActivityController(EmployeeActivityBaseService context)
        {
            _context = context;
        }

        // GET: api/EmployeeActivity/IdAndDate
        [HttpGet("IdAndDate/{id}/{date}")]
        public async Task<IActionResult> GetByIdAndDate(int id, DateTime date)
        {
            try
            {
                var result = await _context.GetTimeTrackingByPersonIdAndDate(id, date);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        // GET: api/EmployeeActivity/IdAndWeek
        [HttpGet("IdAndWeek/{id}/{week}")]
        public async Task<IActionResult> GetByIdAndWeek(int id, int week)
        {
            try
            {
                return Ok(await _context.GetTimeTrackingByPersonIdAndWeekNumber(id, week));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}