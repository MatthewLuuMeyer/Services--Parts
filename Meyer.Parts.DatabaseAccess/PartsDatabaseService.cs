using System.Threading.Tasks;

namespace Meyer.Parts.DatabaseAccess;

public class PartsDatabaseService(PartsDatabaseContext dbContext) : IPartsService
{
    public Task PlaceHolder()
    {
        // Placeholder for EF Calls
        return Task.CompletedTask;
    }
}