using System;
using MongoDB.Driver;

namespace Gaz_vod_Praktika.Data
{
    public class MongoDb
    {
        static MongoClient client;
        static IMongoDatabase UserDatabase;
        static IMongoCollection<User> UsersCollection;
        static IMongoCollection<Project> ProjectsCollection;
        static IMongoCollection<VodDoc> VodDocCollection;
        static IMongoCollection<GazDoc> GazDocCollection;

        static MongoDb()
        {
            client = new MongoClient();
            UserDatabase = client.GetDatabase("GazVodPraktika");
            UsersCollection = UserDatabase.GetCollection<User>("Users");
            ProjectsCollection = UserDatabase.GetCollection<Project>("Projects");
            VodDocCollection = UserDatabase.GetCollection<VodDoc>("VodDoc");
            GazDocCollection = UserDatabase.GetCollection<GazDoc>("GazDoc");
        }
        #region User
        public static void AddToDBUser(User newUser)
        {
            UsersCollection.InsertOne(newUser);
        }
        public static User FindUser(string Login)
        {
            return UsersCollection.Find(x => x.Login == Login).FirstOrDefault();
        }
        public static void ReplaceUser(string Login, User newUser)
        {
            UsersCollection.ReplaceOne(x => x.Login == Login, newUser);
        }
        #endregion
        #region Projects
        public static void AddToDBProject(Project newProject)
        {
            ProjectsCollection.InsertOne(newProject);
        }
        public static Project FindProject(string Name)
        {
            return ProjectsCollection.Find(x => x.Name == Name).FirstOrDefault();
        }
        public static void ReplaceProject(string Name, Project newProject)
        {
            ProjectsCollection.ReplaceOne(x => x.Name == Name, newProject);
        }
        #endregion
        #region VodDoc
        public static void AddToDBVodDoc(VodDoc newVodDoc)
        {
            VodDocCollection.InsertOne(newVodDoc);
        }
        public static VodDoc FindVodDoc(string DesignerLogin)
        {
            return VodDocCollection.Find(x => x.DesignerLogin == DesignerLogin).FirstOrDefault();
        }
        public static void ReplaceVodDoc(string DesignerLogin, VodDoc newVodDoc)
        {
            VodDocCollection.ReplaceOne(x => x.DesignerLogin == DesignerLogin, newVodDoc);
        }
        #endregion
        #region GazDoc
        public static void AddToDBGazDoc(GazDoc newGazDoc)
        {
            GazDocCollection.InsertOne(newGazDoc);
        }
        public static GazDoc FindGazDoc(string DesignerLogin)
        {
            return GazDocCollection.Find(x => x.DesignerLogin == DesignerLogin).FirstOrDefault();
        }
        public static void ReplaceGazDoc(string DesignerLogin, GazDoc newGazDoc)
        {
            GazDocCollection.ReplaceOne(x => x.DesignerLogin == DesignerLogin, newGazDoc);
        }
        #endregion
    }
}
