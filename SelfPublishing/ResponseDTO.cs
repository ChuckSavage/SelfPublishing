using XmlLib;

namespace SelfPublishing
{
    public class ResponseDTO : ILoadXml
    {
        public ResponseDTO()
        {
            Quote = new DetailDTO();
            Error = new ErrorDTO();
        }
        public string Version { get; set; }
        public string StatusCode { get; set; }
        public ErrorDTO Error { get; set; }
        public DetailDTO Quote { get; set; }

        public void LoadXml(System.Xml.Linq.XElement e)
        {
            Version = e.Get("Version", "Invalid XML");
            StatusCode = e.Get("StatusCode", "Invalid XML");
            Error.LoadXml(e.Element("Error"));
            Quote.LoadXml(e.Element("Quote"));
        }
    }
}
