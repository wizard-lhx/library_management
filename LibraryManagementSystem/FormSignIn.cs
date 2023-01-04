using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
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
}
