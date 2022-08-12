namespace myApp.Core.Dtos
{
    public class ActiveWorksDto : BaseDto
    {
        public int CustomerId { get; set; }
        public int DeviceId { get; set; }
        public int TechnicalServiceId { get; set; }
        public DateTime Date { get; set; }
        public string Problem { get; set; }
    }
}
