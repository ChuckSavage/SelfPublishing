using System.Diagnostics;
using XmlLib;

namespace SelfPublishing
{
    [DebuggerDisplay("{Code} - {Description}")]
    public class ErrorDTO : ILoadXml
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public void LoadXml(System.Xml.Linq.XElement e)
        {
            if (null != e)
            {
                Code = e.Get("Code", "Invalid XML");
                Description = e.Get("Description", "Invalid XML");
            }
        }
    }
}
