namespace myApp.Core.Dtos
{
    public class TechnicalServiceDto : BaseDto
    {
        public string BrandName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public float Rating { get; set; }
        public string Website { get; set; }
        public int DeviceId { get; set; }
    }
}
