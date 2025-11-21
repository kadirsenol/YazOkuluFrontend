namespace YazOkuluFrontend.Models.DTO
{
    public class CourseDto
    {
        public int? CourseID { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int? Quota { get; set; }
        public int? FacultyID { get; set; }
        public int? DepartmentID { get; set; }
        public int? CurrentQuota { get; set; }

    }
}
