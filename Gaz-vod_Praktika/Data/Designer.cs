using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Gaz_vod_Praktika.Data
{
    public class Designer : User
    {
        private string Ogrn;
        private string Inn;
        private string Kpp;
        private string adress;
        private string director;
        private string chiefProjectEngineer;
        public Designer(string login, string password, string lName, string fName, string patronymic, string phone, string email, string Ogrn, string Inn, string Kpp, string adress, string director, string chiefProjectEngineer)
            : base(login, password, lName, fName, patronymic, phone, email)
        {
            OGRN = Ogrn;
            INN = Inn;
            KPP = Kpp;
            Adress = adress;
            Director = director;
            ChiefProjectEngineer = chiefProjectEngineer;
        }
        public string OGRN { get { return Ogrn; } set { Ogrn = value; } }
        public string INN { get { return Inn; } set { Inn = value; } }
        public string KPP { get { return Kpp; } set { Kpp = value; } }
        public string Adress { get { return adress; } set { adress = value; } }
        public string Director { get { return director; } set { director = value; } }
        public string ChiefProjectEngineer { get { return chiefProjectEngineer; } set { chiefProjectEngineer = value; } }
    }
}
