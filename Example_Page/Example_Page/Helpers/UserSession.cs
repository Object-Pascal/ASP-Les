using System.Web;

namespace Example_Page
{
    public static class UserSession
    {
        public static User currentUser
        {
            get
            {
                return (User)HttpContext.Current.Session["currentUser"];
            }
            set
            {
                HttpContext.Current.Session["currentUser"] = value;
            }
        }

        public static void AllocateSessionVariables()
        {
            HttpContext.Current.Session["currentUser"] = new User("Pascal", "Stoop", 19);
        }
    }
}