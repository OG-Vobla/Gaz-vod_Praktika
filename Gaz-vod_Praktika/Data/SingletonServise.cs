
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
        private Project project;
        public Project GetProject()
        {
            return project;
        }

        public void SetProject(Project project)
        {
            this.project = project;
        }
    }

}
