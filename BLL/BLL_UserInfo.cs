using System.Reflection;

namespace BLL
{
    public class BLL_UserInfo
    {
        private DAL.UserInfo dal_userInfo = new DAL.UserInfo();
        //增加用户
        public bool UserAdd(Model.Mod_UserInfo mod_userInfo)
        {
            //判断信息是否为空
            if(mod_userInfo != new Model.Mod_UserInfo())
            {
                if(mod_userInfo.UserID.Length == 12)
                {
                    dal_userInfo.UserAdd(mod_userInfo);
                    return true;
                }
            }
            return false;
        }
        //列举用户
        public List<Model.Mod_UserInfo> UserList()
        {
            List<Model.Mod_UserInfo> userInfos = dal_userInfo.UserList();
            return userInfos;
        }
        //查找用户
        public Model.Mod_UserInfo UserSearch(string id)
        {
            Model.Mod_UserInfo userInfo = dal_userInfo.UserSearch(id);
            return userInfo;
        }
        //修改用户
        public bool UserUpdate(Model.Mod_UserInfo mod_userInfo)
        {
            if (mod_userInfo != new Model.Mod_UserInfo())
            {
                if (mod_userInfo.UserID.Length == 12)
                {
                    dal_userInfo.UserUpdate(mod_userInfo);
                    return true;
                }
            }
            return false;
        }
        //删除用户
        public void UserDelete(Model.Mod_UserInfo mod_userInfo)
        {
            dal_userInfo.UserDelete(mod_userInfo.UserID);
        }
        //登录用户
        public bool UserSignIn(Model.Mod_UserInfo mod_userInfo)
        {
            //获取数据库中用户信息列表
            List<Model.Mod_UserInfo> userInfos = UserList();

            //判断是否符合登录标准（需要root用户）
            foreach (Model.Mod_UserInfo userInfo in userInfos)
            {
                if (mod_userInfo.UserID.Equals(userInfo.UserID) && 
                    mod_userInfo.UserPWD.Equals(userInfo.UserPWD) &&
                    mod_userInfo.UserType.Equals("root"))
                { 
                    return true;
                }
            }
            return false;
        }
    }
}