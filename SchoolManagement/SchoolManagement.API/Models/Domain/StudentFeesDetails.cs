namespace SchoolManagement.API.Models.Domain
{
    public class StudentFeesDetails
    {
        public int StudentId {  get; set; }
        public int FeeTermId { get; set; }
        public int FeeTermAmount { get; set; }
        public bool IsPaid { get; set; }
    }
}
