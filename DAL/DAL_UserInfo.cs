using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace DAL
{
    public class UserInfo
    {
        //新建用户
        public void UserAdd(Model.Mod_UserInfo mod_userInfo)
        {
            //sql执行语句
            string sqlStr = "insert into tUser(userID, userName, userPWD, userType)" +
                "values(@id, @name, @pwd, @type)";
            
            //语句中的参数设置
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id", mod_userInfo.UserID),
                new SqlParameter("@name", mod_userInfo.UserName),
                new SqlParameter("@pwd", mod_userInfo.UserPWD),
                new SqlParameter("@type", mod_userInfo.UserType)
            };

            //执行sql语句
            SqlHelper.ExecuteNonQuery(SqlHelper.connectionString, System.Data.CommandType.Text, sqlStr, param);
        }

        //列出所有用户
        public List<Model.Mod_UserInfo> UserList()
        {
            string sqlStr = "select * from tUser";

            //获取数据集
            DataSet dataset = new DataSet();
            dataset = SqlHelper.ExecuteDataset(SqlHelper.connectionString, System.Data.CommandType.Text, sqlStr);
            
            //定义实体类列队
            List<Model.Mod_UserInfo> userInfos = new List<Model.Mod_UserInfo>();
            
            //将数据集中的数据按行读取输入到实体类列队中
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                Model.Mod_UserInfo mod_userInfo = new Model.Mod_UserInfo();
                mod_userInfo.UserID = row["userID"].ToString();
                mod_userInfo.UserName = row["userName"].ToString();
                mod_userInfo.UserPWD = row["userPWD"].ToString();
                mod_userInfo.UserType = row["userType"].ToString();
                userInfos.Add(mod_userInfo);
            }

            return userInfos;
        }
        //查询用户
        public Model.Mod_UserInfo UserSearch(string userID)
        {
            string sqlStr = "select * from tUser where userID = @id";

            //设置参数并执行
            DataSet dataset = new DataSet();
            dataset = SqlHelper.ExecuteDataset(SqlHelper.connectionString,
            System.Data.CommandType.Text, sqlStr, new SqlParameter("@id", userID));

            //将获取数据赋给单个实体
            Model.Mod_UserInfo mod_userInfo = new Model.Mod_UserInfo();
            DataRow row = dataset.Tables[0].Rows[0];
            mod_userInfo.UserID = row["userID"].ToString();
            mod_userInfo.UserName = row["userName"].ToString();
            mod_userInfo.UserPWD = row["userPWD"].ToString();
            mod_userInfo.UserType = row["userType"].ToString();

            return mod_userInfo;
        }

        //更新用户
        public void UserUpdate(Model.Mod_UserInfo mod_userInfo)
        {
            string sqlStrSetName = "update tUser set userName = @name where userID = @id";
            string sqlStrSetPWD = "update tUser set userPWD = @pwd where userID = @id";
            string sqlStrSetType = "update tUser set userType = @type where userID = @id";
            
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id", mod_userInfo.UserID),
                new SqlParameter("@name", mod_userInfo.UserName),
                new SqlParameter("@pwd", mod_userInfo.UserPWD),
                new SqlParameter("@type", mod_userInfo.UserType)
            };

            SqlHelper.ExecuteNonQuery(SqlHelper.connectionString, System.Data.CommandType.Text, sqlStrSetName, param);
            SqlHelper.ExecuteNonQuery(SqlHelper.connectionString, System.Data.CommandType.Text, sqlStrSetPWD, param);
            SqlHelper.ExecuteNonQuery(SqlHelper.connectionString, System.Data.CommandType.Text, sqlStrSetType, param);
        }

        //删除用户
        public void UserDelete(string id)
        {
            string sqlStr = "delete from tUser where userID = @id";
            SqlHelper.ExecuteNonQuery(SqlHelper.connectionString, System.Data.CommandType.Text,
                sqlStr, new SqlParameter("@id", id));
        }
    }
}