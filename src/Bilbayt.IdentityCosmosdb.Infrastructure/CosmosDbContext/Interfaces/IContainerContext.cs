using Bilbayt.IdentityCosmosDb.Application.Entities.Base;
using Microsoft.Azure.Cosmos;

namespace Bilbayt.IdentityCosmosdb.Infrastructure.CosmosDbContext.Interfaces
{
    /// <summary>
    ///  Defines the container level context
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IContainerContext<T> where T : BaseEntity
    {
        string ContainerName { get; }
        string GenerateId(T entity);
        PartitionKey ResolvePartitionKey(string entityId);
    }
}
