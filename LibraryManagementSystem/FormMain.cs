using BLL;
using LibraryManager;
using Model;

namespace LibraryManagementSystem
{
    //主窗口类
    public partial class FormMain : Form
    {
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
        public FormMain()
        {
            InitializeComponent();
        }

        //主窗口加载程序
        private void FormMain_Load(object sender, EventArgs e)
        {
            //向主窗口增加一个窗口控件，使主窗口内能够切换多个小窗口
            ControlWin_ListUserInfo formListUserInfo = new ControlWin_ListUserInfo();
            panWin.Controls.Add(formListUserInfo);
        }

        //删除按钮触发事件
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //获取输出列表的引用
            Control? control = GetControl(panWin.Controls);
            ListView lstView = new ListView();
            if (control != null)
            {
                lstView = (ListView)(control);
            }
            else
            {
                this.Close();
            }

            Model.Mod_UserInfo mod_userinfo = new Model.Mod_UserInfo();
            BLL_UserInfo bll_userinfo = new BLL_UserInfo();

            //判断是否选中行
            if (lstView.SelectedItems.Count == 0)
            {
                MessageBox.Show("There is no selected row!", "Wrong");
            }
            else
            {
                //获取选中行的信息
                mod_userinfo.UserID = lstView.SelectedItems[0].SubItems[0].Text;
                mod_userinfo.UserName = lstView.SelectedItems[0].SubItems[1].Text;
                mod_userinfo.UserPWD = lstView.SelectedItems[0].SubItems[2].Text;
                mod_userinfo.UserType = lstView.SelectedItems[0].SubItems[3].Text;
                
                bll_userinfo.UserDelete(mod_userinfo);
            }
        }

        //插入按钮触发事件
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //打开新增用户界面
            FormIncrease forminsert = new FormIncrease();
            forminsert.Show();
        }

        //修改按钮触发事件
        private void btnModify_Click(object sender, EventArgs e)
        {
            Control? control = GetControl(panWin.Controls);
            ListView lstView = new ListView();
            if (control != null)
            {
                lstView = (ListView)(control);
            }
            else
            {
                this.Close();
            }

            //判断是否选中行
            if (lstView.SelectedItems.Count == 0)
            {
                MessageBox.Show("There is no selected row!", "Wrong");
            }
            else
            {
                //定义更新窗口
                FormUpdat form = new FormUpdat();

                //把用户信息传递到更改信息窗口
                form.UserID = lstView.SelectedItems[0].SubItems[0].Text;
                form.Show();
            }
        }

        //类表视图按钮触发事件
        private void btnView_Click(object sender, EventArgs e)
        {
            Control? control = GetControl(panWin.Controls);
            ListView lstView = new ListView();
            if (control != null)
            {
                lstView = (ListView)(control);
            }
            else
            {
                this.Close();
            }

            BLL.BLL_UserInfo bll_userinfo = new BLL.BLL_UserInfo();
            List<Model.Mod_UserInfo> userInfos = bll_userinfo.UserList();
            lstView.Items.Clear();

            //将查询到的信息显示在列表的对应列
            foreach (Model.Mod_UserInfo userInfo in userInfos)
            {
                string[] item = new string[lstView.Columns.Count];
                item[0] = userInfo.UserID;
                item[1] = userInfo.UserName;
                item[2] = userInfo.UserPWD;
                item[3] = userInfo.UserType;
                lstView.Items.Add(new ListViewItem(item));
            }
        }       
    }
}