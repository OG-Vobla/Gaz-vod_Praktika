using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Gaz_vod_Praktika.Data
{
    public class User
    {
        private string login;
        private string password;
        private string lName;
        private string fName;
        private string patronymic;
        private string phone;
        private string email;

        public User(string login, string password, string lName, string fName, string patronymic, string phone, string email)
        {
            Login = login;
            Password = password;
            LName = lName;
            FName = fName;
            Patronymic = patronymic;
            Phone = phone;
            Email = email;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public string Login { get { return login; } set { login = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string FName { get { return fName; } set { fName = value; } }
        public string LName { get { return lName; } set { lName = value; } }
        public string Patronymic { get { return patronymic; } set { patronymic = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }

    }
}
