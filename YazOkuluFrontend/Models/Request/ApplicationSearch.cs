namespace YazOkuluFrontend.Models.Request
{
    public class ApplicationSearch : SearchRequest
    {
        public int? UserID { get; set; }
        public int? CourseID { get; set; }
    }
}
