using Microsoft.Azure.Cosmos;

namespace Bilbayt.IdentityCosmosdb.Infrastructure.CosmosDbContext.Interfaces
{
    public interface ICosmosDbContainer
    {
        /// <summary>
        ///     Instance of Azure Cosmos DB Container class
        /// </summary>
        Container _container { get; }
    }
}
