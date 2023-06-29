using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftWorksStaffApi.Model
{
    public class Staff
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int phone { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
    }
}
