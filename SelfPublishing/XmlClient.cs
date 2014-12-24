using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using ServiceStack.ServiceModel.Serialization;
using XmlLib;

namespace SelfPublishing
{
    public class XmlClient : ServiceStack.ServiceClient.Web.XmlServiceClient
    {
        public XmlClient(string baseUri)
            : base(baseUri)
        {
        }

        public override void SerializeToStream(ServiceStack.ServiceHost.IRequestContext requestContext, object request, System.IO.Stream stream)
        {
            if (request == null) return;
            string xml = DataContractSerializer.Instance.Parse(request);
            XElement root = XElement.Parse(xml);

            XElement lang = root.Descendants("lang").Single();
            lang.Parent.Set("xml:lang", lang.Value, XmlFile.ATTRIBUTE);
            lang.Remove();

            // Version after access
            //SwapAfter(root, "Version", "Access");

            // Phone after Zipcode
            //SwapAfter(root, "Phone", "Zipcode");
            root.Save(stream);
        }

        void SwapAfter(XElement root, string name, string after)
        {
            XElement find = root.Descendants(name).Single();
            find.Remove();
            XElement afterElement = root.Descendants(after).Single();
            afterElement.AddAfterSelf(find);
        }

        public override T DeserializeFromStream<T>(System.IO.Stream stream)
        {
            XmlReader reader = XmlReader.Create(stream);
            XElement root = XElement.Load(reader, LoadOptions.None);

            T item = Activator.CreateInstance<T>();
            ((ILoadXml)item).LoadXml(root);
            return item;
        }
    }
}
