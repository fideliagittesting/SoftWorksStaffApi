using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftWorksStaffApi.Model;
using SoftWorksStaffApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftWorksStaffApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IStaffRepository _staffRepositry;

        public StaffsController(IStaffRepository staffRepositry)
        {
            _staffRepositry = staffRepositry;
        }

        [HttpGet]
        public async Task<IEnumerable<Model.Staff>> GetStaffs()
        {
            return await _staffRepositry.Get();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Staff>> GetStaffs(int Id)
        {
            return await _staffRepositry.Get(Id);
        }

        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff([FromBody] Staff staff) 
        {
            var newStaff = await _staffRepositry.Create(staff);
            return CreatedAtAction(nameof(GetStaffs), new { id = newStaff.Id }, newStaff);
        }

        [HttpPut]
        public async Task<ActionResult<Staff>> PutStaffS([FromBody] Staff staff) 
        {
            int id = 0;
            if (id != staff.Id);
            {
                return BadRequest();
            }
            await _staffRepositry.update(staff);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Staff>> Delete (int id)
        {
            int Id = 0;
            var StaffToDelete = await _staffRepositry.Get(Id);
            if (StaffToDelete == null)
                return NotFound();

            await _staffRepositry.Delete(StaffToDelete.Id);
            return NoContent();
        
        }
    }
}
