using System.Windows;
using SelfPublishing;

namespace TestService
{
    public partial class MainWindow : Window
    {
        XmlClient client = new XmlClient("http://api.selfpublishing.com");
        AccessDTO access;

        public MainWindow()
        {
            InitializeComponent();
            access = new AccessDTO
            {
                Username = Secure.USERNAME, // this is your username from the dashboard at selfpublishing.com
                Key = Secure.KEY, // contact your customer service rep at selfpublishing.com to get your key
                lang = "en-US"
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var quote = new SelfPublishing.Quote.Request
            {
                Access = access,
                Version = "1.0",
                Quantity = 1,
                Title = 0,
                Destination = new DestinationDTO
                {
                    Address1 = "500 Arapahoe Road",
                    City = "Boulder",
                    State = "CO",
                    Zipcode = "80303",
                    Phone = "123-456-7890"
                }
            };
            var response = client.Post<SelfPublishing.Quote.Response>("/storagefulfillment/quote/", quote);
            var r = response;
        }
    }
}
