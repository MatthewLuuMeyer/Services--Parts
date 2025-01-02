using Meyer.Services.Connectors.Http;

namespace Meyer.Parts.Connector
{
    public class PartsHttpService : IPartsService
    {
        private readonly ServiceHttpClient _httpClient;
        public PartsHttpService(ServiceHttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ItemQuantity>> GetItemQuantities(List<ItemLocationRequest> items)
        {
            return await _httpClient.Post<List<ItemQuantity>>("Parts/quantity", items);
        }
    }
}
