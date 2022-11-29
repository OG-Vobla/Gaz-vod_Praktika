using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Gaz_vod_Praktika.Data
{
	public class Customer : User
	{
		private string department;
        private string post;
        public Customer(string login, string password, string lName, string fName, string patronymic, string phone, string email, string department, string post) : base(login, password, lName, fName, patronymic, phone, email)
		{
            Department = department;
            Post = post;
		}
        public string Department { get { return department; } set { department = value; } }
        public string Post { get { return post; } set { post = value; } }
    }
}
