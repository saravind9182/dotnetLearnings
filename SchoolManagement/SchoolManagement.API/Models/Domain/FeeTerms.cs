namespace SchoolManagement.API.Models.Domain
{
    public class FeeTerms
    {
        public int Id { get; set; }
        public long AmountToBe { get; set; }
        public DateTime DueDate { get; set; }
    }
}
