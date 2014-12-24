
namespace SelfPublishing
{
    public class DestinationDTO
    {
        public DestinationDTO()
        {
            Address2 = "";
        }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
    }
}
