namespace YazOkuluFrontend.Models.Response
{
    public class CourseItem
    {
        public int? CourseID { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Quota { get; set; }
        public int FacultyID { get; set; }
        public string FacultyName { get; set; } = string.Empty;
        public int? DepartmentID { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public int? CurrentQuota { get; set; }

    }
}
