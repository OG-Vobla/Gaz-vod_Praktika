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

        static MongoDb()
        {
            client = new MongoClient();
            UserDatabase = client.GetDatabase("GazVodPraktika");
            UsersCollection = UserDatabase.GetCollection<User>("Users");
            ProjectsCollection = UserDatabase.GetCollection<Project>("Projects");
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
        public static List<User> FindAllDesigner()
        {
            var list = UsersCollection.Find(x => true).ToList();
            var users = new List<User>();
            foreach (var user in list)
            {
                if (user.GetType().Name == "Designer")
                    users.Add(user);
            }
            return users;
        }
        public static List<User> FindAllBuilder()
        {
            var list = UsersCollection.Find(x => true).ToList();
            var users = new List<User>();
            foreach (var user in list)
            {
                if (user.GetType().Name == "Builder")
                    users.Add(user);
            }
            return users;
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
        public static List<Project> FindAllProject()
        {
            return ProjectsCollection.Find(x => true).ToList();

        }
        #endregion
    }
}
