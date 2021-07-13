using Newtonsoft.Json;

namespace Bilbayt.IdentityCosmosDb.Application.Entities.Base
{
    public abstract class BaseEntity
    {
        [JsonProperty(PropertyName = "id")]
        public virtual string Id { get; set; }
    }
}
