using Microsoft.Extensions.Hosting;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Gaz_vod_Praktika.Data
{
    public class Project
    {
        private string name;
        private string description;
        private string customerLogin;
        private string builderLogin;
        private string designerLogin;

        public Project(string name, string description, string customerLogin, string builderLogin, string designerLogin)
        {
            Name = name;
            Description = description;
            CustomerLogin = customerLogin;
            BuilderLogin = builderLogin;
            DesignerLogin = designerLogin;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string CustomerLogin { get { return customerLogin; } set { customerLogin = value; } }
        public string BuilderLogin { get { return builderLogin; } set { builderLogin = value; } }
        public string DesignerLogin { get { return designerLogin; } set { designerLogin = value; } }
    }
}
