using System;

namespace SelfPublishing
{
    public class AccessDTO
    {
        public string lang { get; set; } // needs to be an attribute, set as such in XmlClient
        public string Key { get; set; }
        public string Username { get; set; }
    }
}
