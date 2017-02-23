using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Web.Authentication
{
    public interface IAuthenticationService
    {
        void SignIn(UserData userData, bool createPersistentCookie);

        void SignOut();

        UserData GetAuthenticatedUserData();
    }
}
