using XmlLib;

namespace SelfPublishing
{
    public class DetailDTO : ILoadXml
    {
        /// <summary>
        /// Weight of the quoted package
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// Number of calculated cartons
        /// </summary>
        public int Cartons { get; set; }

        /// <summary>
        /// Calculated handling
        /// </summary>
        public decimal Handling { get; set; }

        /// <summary>
        /// Calculated shipping
        /// </summary>
        public decimal Shipping { get; set; }

        /// <summary>
        /// Estimated time from origin to destination
        /// </summary>
        public string TransitTime { get; set; }

        /// <summary>
        /// Method that will be used to ship
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Order ID for this shipment
        /// </summary>
        public string OrderId { get; set; }

        public void LoadXml(System.Xml.Linq.XElement e)
        {
            if (null != e)
            {
                Weight = e.Get("Weight", (decimal)0);
                Cartons = e.Get("Cartons", 0);
                Handling = e.Get("Handling", (decimal)0);
                Shipping = e.Get("Shipping", (decimal)0);
                TransitTime = e.Get("TransitTime", "");
                Method = e.Get("Method", "");
                OrderId = e.Get("OrderId", "");
            }
        }
    }
}
