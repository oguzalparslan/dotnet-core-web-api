namespace myApp.Core.Dtos
{
    public class ActiveWorksDto : BaseDto
    {
        public string Date { get; set; }
        public string TrackingCode { get; set; }
        public string Problem { get; set; }

        //Foreign Keys
        public int CustomerId { get; set; }
        public int DeviceId { get; set; }
        public int TechnicalServiceId { get; set; }
    }
}
