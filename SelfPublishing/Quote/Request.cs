
namespace SelfPublishing.Quote
{
    public class Request : RequestDTO
    {
        public Request()
            : base()
        {
            Destination = new DestinationDTO();
        }

        public DestinationDTO Destination { get; set; }

    }
}
