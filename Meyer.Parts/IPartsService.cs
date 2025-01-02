using System.Threading.Tasks;
using System.Collections.Generic;

namespace Meyer.Parts
{
    public interface IPartsService
    {
        Task<List<ItemQuantity>> GetItemQuantities(List<ItemLocationRequest> items);
    }
}
