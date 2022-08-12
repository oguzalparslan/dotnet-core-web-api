namespace myApp.Core.Models
{
    public class TechnicalService : BaseEntity
    {
        public string BrandName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public float Rating { get; set; }
        public string Website { get; set; }
        //Foreign Keys
        public int DeviceId { get; set; }
    }
}
