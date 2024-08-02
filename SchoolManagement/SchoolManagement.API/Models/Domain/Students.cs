namespace SchoolManagement.API.Models.Domain
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public int Class { get; set; }
        public long MobileNo { get; set; }
        public int DriverId { get; set; }
        
    }
}
