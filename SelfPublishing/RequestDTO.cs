
namespace SelfPublishing
{
    public class RequestDTO
    {
        public RequestDTO()
        {
            Access = new AccessDTO();
            //Destination = new DestinationDTO();
        }
        public AccessDTO Access { get; set; }
        public string Version { get; set; }
        public int Quantity { get; set; }
        public int Title { get; set; }
        //public DestinationDTO Destination { get; set; }
    }
}
