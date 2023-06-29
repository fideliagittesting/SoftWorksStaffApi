using Microsoft.EntityFrameworkCore;
using SoftWorksStaffApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftWorksStaffApi.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        private readonly StaffContext _context;

        public StaffRepository(StaffContext context) 
        {
            _context = context;
        
        }

        public Staff staff { get; private set; }

        public async Task<Staff> Create(Staff staff)
        {
            _context.Staffs.Add(staff);
            await _context.SaveChangesAsync();

            return staff;
            
        }

        public async Task<Staff> Delete(int Id)
        {
            var StaffToDelete = await _context.Staffs.FindAsync(Id);
            _context.Staffs.Remove(StaffToDelete);
            await _context.SaveChangesAsync();

            return staff;
        }

        public async Task<IEnumerable<Staff>> Get()
        {
            return await _context.Staffs.ToListAsync();
        }

        public async Task<Staff> Get(int Id)
        {
            return await _context.Staffs.FindAsync();
        }

        public async Task update(Staff staff)
        {
            _context.Entry(staff).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
