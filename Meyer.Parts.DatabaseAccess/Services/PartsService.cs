using System.Threading.Tasks;
using Meyer.Parts.DatabaseAccess.Database;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Meyer.Parts.DatabaseAccess.Services;

public class PartsService : IPartsService
{
    private readonly PartsDatabaseContext _dbContext;
    private readonly IMapper _mapper;

    public PartsService(PartsDatabaseContext dbContext, IMapper mapper)
    { 
        _dbContext = dbContext;
        _mapper = mapper;
    }
    public async Task<List<ItemQuantity>> GetItemQuantities(List<string> itemNumbers)
    {
        var entities = await _dbContext.ItemQuantities.Where(r => itemNumbers.Contains(r.ItemNumber)).ToListAsync();
        return _mapper.Map<List<ItemQuantity>>(entities);
    }
}