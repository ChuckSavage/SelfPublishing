
namespace SelfPublishing
{
    public class DestinationDTOFull : DestinationDTO
    {
        public DestinationDTOFull()
            : base()
        {
            Firstname = "";
            Lastname = "";
            Email = "";
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}
