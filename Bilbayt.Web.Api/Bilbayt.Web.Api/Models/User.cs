using AspNetCore.Identity.Mongo.Model;

namespace Bilbayt.Web.Api.Models
{
    public class User : MongoUser
    {
        public string FullName { get; set; }
    }
}