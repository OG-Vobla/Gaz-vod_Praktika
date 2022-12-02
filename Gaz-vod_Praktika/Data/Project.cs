using Microsoft.Extensions.Hosting;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Gaz_vod_Praktika.Data
{
    public class Project
    {
        private string name;
        private string type;
        private string customerLogin;
        private string builderLogin;
        private string designerLogin;

        public Project(string name, string type, string customerLogin, string builderLogin, string designerLogin)
        {
            Name = name;
            Type = type;
            CustomerLogin = customerLogin;
            BuilderLogin = builderLogin;
            DesignerLogin = designerLogin;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public string Name { get { return name; } set { name = value; } }
        public string Type { get { return type; } set { type = value; } }
        public string CustomerLogin { get { return customerLogin; } set { customerLogin = value; } }
        public string BuilderLogin { get { return builderLogin; } set { builderLogin = value; } }
        public string DesignerLogin { get { return designerLogin; } set { designerLogin = value; } }
        [BsonIgnoreIfNull]
        public List<DeveloperDocument> Documents = new List<DeveloperDocument>();

        [BsonIgnoreIfNull]
        public List<PlannerDocument> Documentss = new List<PlannerDocument>();
    }
}
