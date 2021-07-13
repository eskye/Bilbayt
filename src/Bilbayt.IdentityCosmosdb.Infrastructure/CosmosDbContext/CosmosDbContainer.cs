using Bilbayt.IdentityCosmosdb.Infrastructure.CosmosDbContext.Interfaces;
using Microsoft.Azure.Cosmos;

namespace Bilbayt.IdentityCosmosdb.Infrastructure.CosmosDbContext
{
    public class CosmosDbContainer : ICosmosDbContainer
    {
        public Container _container { get; }

        public CosmosDbContainer(CosmosClient cosmosClient,
                                 string databaseName,
                                 string containerName)
        {
            this._container = cosmosClient.GetContainer(databaseName, containerName);
        }
    }
}
