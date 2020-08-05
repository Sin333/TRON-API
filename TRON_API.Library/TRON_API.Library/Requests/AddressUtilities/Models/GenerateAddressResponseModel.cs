namespace TRON_API.Library.Requests.AddressUtilities.Models
{
    public class GenerateAddressResponseModel
    {
        public string PrivateKey { get; set; }
        public string Address { get; set; }
        public string HexAddress { get; set; }
    }
}