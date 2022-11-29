using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Xml.Linq;

namespace Gaz_vod_Praktika.Data
{
    public class Builder : User
    {
        private string Ogrn;
        private string Inn;
        private string Kpp;
        private string adress;
        private string headExecutiveCommittee;
        public Builder(string login, string password, string lName, string fName, string patronymic, string phone, string email, string Ogrn, string Inn, string Kpp, string adress, string headExecutiveCommittee)
            : base(login, password, lName, fName, patronymic, phone, email)
        {
            OGRN = Ogrn;
            INN = Inn;
            KPP = Kpp;
            Adress = adress;
            HeadExecutiveCommittee = headExecutiveCommittee;
        }
        public string OGRN { get { return Ogrn; } set { Ogrn = value; } }
        public string INN { get { return Inn; } set { Inn = value; } }
        public string KPP { get { return Kpp; } set { Kpp = value; } }
        public string Adress { get { return adress; } set { adress = value; } }
        public string HeadExecutiveCommittee { get { return headExecutiveCommittee; } set { headExecutiveCommittee = value; } }
    }
}
