namespace TRON_API.Library
{
    public class TronApiConfiguration
    {
        public readonly string FullNodeURL;
        public readonly string SolidityNodeURL;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="fullNodeUrl">Example: "http://localhost:8090/"</param>
        /// <param name="solidityNodeUrl">Example: "http://localhost:8091/"</param>
        public TronApiConfiguration(string fullNodeUrl, string solidityNodeUrl)
        {
            FullNodeURL = fullNodeUrl;
            SolidityNodeURL = solidityNodeUrl;
        }
    }
}