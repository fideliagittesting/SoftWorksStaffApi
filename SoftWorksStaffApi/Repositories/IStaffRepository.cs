using SoftWorksStaffApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftWorksStaffApi.Repositories
{
    public interface IStaffRepository
    {
        Task<IEnumerable<Staff>> Get();
        Task<Staff> Get(int Id);
        Task<Staff> Create(Staff staff);
        Task update(Staff staff);
        Task<Staff> Delete(int Id);

    }
}