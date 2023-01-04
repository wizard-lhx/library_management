using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    //增加用户窗口类
    public partial class FormIncrease : Form
    {
        private BLL.BLL_UserInfo bll_UserInfo = new BLL.BLL_UserInfo();
        public FormIncrease()
        {
            InitializeComponent();
        }
        private void FormIncrease_Load(object sender, EventArgs e)
        {

        }

        //不能同时选中两种复选框
        private void chkReader_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReader.Checked) { chkRoot.Checked = false; }
            else { chkRoot.Checked = true; }
        }
        private void chkRoot_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRoot.Checked) { chkReader.Checked = false; }
            else { chkReader.Checked = true; }
        }

        //增加按钮触发事件
        private void btnIncreaser_Click(object sender, EventArgs e)
        {
            Model.Mod_UserInfo mod_UserInfo = new Model.Mod_UserInfo();

            mod_UserInfo.UserID = txtID.Text;
            mod_UserInfo.UserName = txtName.Text;
            mod_UserInfo.UserPWD = txtPWD.Text;
            if(chkReader.Checked == true)
            {
                mod_UserInfo.UserType = "reader";
            }
            else
            {
                mod_UserInfo.UserType = "root";
            }

            //判断是否增加成功
            if(bll_UserInfo.UserAdd(mod_UserInfo))
            {
                Form form = btnIncreaser.FindForm();
                form.Close();
            }
            else
            {
                MessageBox.Show("User ID Wrong!", "Wrong");
            }
        }
    }
}
