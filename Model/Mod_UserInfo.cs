namespace Model
{
    public class Mod_UserInfo
    {
        public Mod_UserInfo()
        {
            UserID = "";
            UserName = "";
            UserPWD = "";
            UserType = "reader";
        }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserPWD { get; set; }
        public string UserType { get; set; }
    }
}