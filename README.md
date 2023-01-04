# 图书馆管理系统（C/S架构软件）开发

> 主要步骤

> 遇见问题

## 1 主要步骤
### 1.1 学习主干知识
- 大概懂得数据库相关sql语法
- 大概懂得C#语法（[C#菜鸟教程](https://www.runoob.com/csharp/csharp-tutorial.html)）把基础篇看看
- 大概掌握.Net开发窗口界面（[.Net教程](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/get-started/create-app-visual-studio?view=netdesktop-6.0)）然后可以实战一下项目（[VS2022创建窗口界面教程](https://learn.microsoft.com/zh-cn/visualstudio/ide/create-csharp-winform-visual-studio?toc=%2Fvisualstudio%2Fget-started%2Fcsharp%2Ftoc.json&bc=%2Fvisualstudio%2Fget-started%2Fcsharp%2Fbreadcrumb%2Ftoc.json&view=vs-2022)）
- 大概理解三层架构
- 进入实战进一步理解所学知识

### 1.2 实战
#### 1.2.1 建立三层架构
在资源管理器里的解决方案添加几个C#类库项目分别对应Model层、DAL层、BLL层。
然后建立项目间的依赖关系。DAL层、UI层、BLL层都引用Model层。BLL层再引用DAL层，UI层再引用BLL层。
#### 1.2.2 创建数据库
根据需求建立对应的数据库、表、视图等。具体数据库设计可以看设计文档。
#### 1.2.3 Model(实体层搭建)
主要就是加入几个属性，例如用户的ID，Name，Password，Type。
``` c#
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
```
#### 1.2.4 DAL层搭建
> 创建增、删、改、查等简单方法，这个分为两步
- 建立与数据库的底层连接（这些方法一般直接用现成的例如sqlhelp类等）
其中比较常调用的是ExecuteNonQuery、ExecuteDataset这两个函数他们的底层也不用深究传几个参数就行。使用方法主要看函数上面的注释。ExecuteNonQuery这个函数主要执行一些不用返回什么值的操作，而ExecuteDataset主要执行一些查询操作可以返回信息列表等。
- 建立自己相应的执行函数。
```c#
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
```
#### 1.2.5 BLL层搭建
这一层主要对传进来的数据进行逻辑判断的操作
```c#
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
```
#### 1.2.6 UI层搭建
这一层主要是与用户的交互，以登录界面的设计为例。
```c#
//登录窗口类
public partial class FormSignIn : System.Windows.Forms.Form
{
    public FormSignIn()
    {
        InitializeComponent();
    }
    private void FormSignIn_Load(object sender, EventArgs e)
    {

    }
    
    //登录按钮触发事件
    private void btnSignIn_Click(object sender, EventArgs e)
    {
        Model.Mod_UserInfo mod_userInfo = new Model.Mod_UserInfo();
        BLL.BLL_UserInfo bll_userInfo = new BLL.BLL_UserInfo();

        //获取用户输入信息
        mod_userInfo.UserID = textBoxUserID.Text;
        mod_userInfo.UserPWD = textBoxUserPWD.Text;
        if(chkBoxReader.Checked )
        {
            mod_userInfo.UserType = "reader";
        }
        else
        {
            mod_userInfo.UserType = "root";
        }

        //传给bll层判断是否符合
        if (bll_userInfo.UserSignIn(mod_userInfo))
        {
            this.DialogResult = DialogResult.OK;
        }
        else
        {
            MessageBox.Show("ID or PassWord wrong.", "Wrong");
        }
    }

    //复选框触发事件（不能同时选root和reader）
    private void chkBoxRoot_CheckedChanged(object sender, EventArgs e)
    {
        if (chkBoxRoot.Checked) { chkBoxReader.Checked = false; }
        else { chkBoxReader.Checked = true; }
    }

    private void chkBoxReader_CheckedChanged(object sender, EventArgs e)
    {
        if (chkBoxReader.Checked) { chkBoxRoot.Checked = false; }
        else { chkBoxRoot.Checked = true; }
    }
}
```

## 2 遇见问题
### 2.1 Windows上.Net开发环境搭建
在搭建.Net开发环境时主要遇到VS2022中无法加载进入桌面应用项目。右键资源管理器选择手动加载时报错"无法找到 .Net SDK,请确保已安装此项目的'global.json'中指定的版本与所安装的版本一致"

根据“找不到 .Net SDK”,先找到"C:\Program Files\dotnet"这个安装 .Net SDK 的地方确保已安装 .Net 。同时打开sdk文件夹如果没有6.0或以上的版本，先安装 .Net 。

如果已有.Net可以打开cmd窗口使用
```
dotnet info
```
打印.Net相关信息可能会显示Program Files（X86）的 .Net，这时去改一下环境变量把(X86)的dotnet路径删掉。添加"Program Files/dotnet"这时再打印下就会改用64位的 .Net。

然后还有版本可能是最新的可以通过
```
dotnet --version
```
查询当前使用的版本。然后通过global.json进行修改成自己需要的版本。如
```
dotnet new globaljson --sdk-version 3.1.100
```
可以把当前使用版本调整为3.1。

### 2.2 与数据库进行连接时遇到问题
- 方法一：先建立sqlconnection这是个类对象，然后对它的属性填入自己连接的数据库信息。而这个类需要导入一个必要的NuGet包"System.Data.SqlClient"。导入方法就是点击菜单栏的项目，然后有一个导入NuGet包，再浏览搜索这个名字，下载就行。
- 方法二：这个其实是建立再方法一上的，只不过只需要定义一个连接字符串
```C#
public static string connectionString = "Data Source=127.0.0.1;Initial Catalog=dbLibrary;User ID=sa;Password=123;";
```
再调用"SqlConnection(connectionString)"这个函数就行了。这其实就又回到方法一。
### 2.3 UI层设计时实现主窗口内多个窗口的切换效果
首先需要再主窗口加入panel面板，然后再在面板内添加窗体控件（注意不是窗体）。可以先设计好子窗体控件然后在运行时将它加入主窗口的面板处。
```c#
//主窗口加载程序
private void FormMain_Load(object sender, EventArgs e)
{
    //向主窗口增加一个窗口控件，使主窗口内能够切换多个小窗口
    ControlWin_ListUserInfo formListUserInfo = new ControlWin_ListUserInfo();
    panWin.Controls.Add(formListUserInfo);
}
```
### 2.4 获取控件
获取子窗体控件里的控件也十分重要，这时需要用到pannel.Controls或者form.Controls等控件集合属性。将他们的集合遍历一下就可以了。
```c#
//获取窗体或面板里的控件
private Control? GetControl(Control.ControlCollection controlCollection)
{
    foreach (Control control in controlCollection)
    {
        //获取控件里的控件
        if (control.Controls.Count != 0)
            return GetControl(control.Controls);
        else
            return control;
    }
    return null;
}
```
### 2.5 登录窗口与主窗口运行顺序
在winform项目中程序一般在主函数开始执行后就会添加一个窗口的线程（就是无限循环），这是如果你有一个登录窗口和一个主窗口，程序会先进入登录。这时，如果想关掉这个窗口
```
this.Close();
```

那整个程序就关掉了，无法再进入主窗口。我的做法是先让登录窗口作为一个对话框显示，登录成功后，让对话框改变一个值，主程序就判断该值，如果该值为真，就开始主窗口的线程。

```c#
static void Main()
{
    FormSignIn formSignIn = new FormSignIn();
                
    if (formSignIn.ShowDialog() == DialogResult.OK)
    {
        Application.Run(new FormMain());
    }
    else
    {
        return;
    }
}
```
## 3 项目地址
[现在还没有](https://github.com/wizard-lhx/Library_Manage)
