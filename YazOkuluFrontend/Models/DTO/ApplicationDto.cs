using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazOkuluFrontend.Models.DTO
{
    public class ApplicationDto
    {
        public int? ApplicationID { get; set; }
        public int? UserID { get; set; }
        public int? CourseID { get; set; }
        public int? StatusID { get; set; }
    }
}
