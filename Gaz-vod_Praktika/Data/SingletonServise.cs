
using System.Collections.Generic;

namespace Gaz_vod_Praktika.Data
{
    public class SingletonServise
    {
        User user;

        public User GetUser()
        {

            return user;
        }
        public void SetUser(User newUser)
        {
            user = newUser;
        }
    }

}
