using System;
using System.Xml.Serialization;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
namespace SelfPublishing
{
    //[AccessFilter]
    public class AccessDTO
    {
        public string lang { get; set; } // needs to be an attribute
        public string Key { get; set; }
        public string Username { get; set; }
    }

    /* Seems like this only works server side
    public class AccessFilterAttribute : RequestFilterAttribute
    {
        public override void Execute(IHttpRequest req, IHttpResponse res, object requestDto)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void RequestFilter(IHttpRequest req, IHttpResponse res, object requestDto)
        {
            //This code is executed before the service
            string userAgent = req.UserAgent;
            //StatisticManager.SaveUserAgent(userAgent);
        }
    }
     */
}
