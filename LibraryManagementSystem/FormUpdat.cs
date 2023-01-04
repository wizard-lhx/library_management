using Microsoft.VisualBasic.ApplicationServices;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class FormUpdat : Form
    {
        public string UserID = string.Empty;
        public FormUpdat()
        {
            InitializeComponent();
        }

        //载入修改用户信息窗口时，先载入选中用户的信息
        private void FormUpdat_Load(object sender, EventArgs e)
        {
            Model.Mod_UserInfo mol_userInfo = new Model.Mod_UserInfo();
            BLL.BLL_UserInfo bll_userInfo = new BLL.BLL_UserInfo();

            //通过UI层传递过来的用户ID寻找剩下的用户信息
            mol_userInfo = bll_userInfo.UserSearch(UserID);
            txtID.Text = mol_userInfo.UserID;
            txtName.Text = mol_userInfo.UserName;
            txtPWD.Text = mol_userInfo.UserPWD;
            if (mol_userInfo.UserType.Equals("reader"))
            {
                chkReader.Checked = true;
                chkRoot.Checked = false;
            }
            else
            {
                chkRoot.Checked = true;
                chkReader.Checked = false;
            }
        }

        private void chkReader_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReader.Checked) { chkRoot.Checked = false; }
            else { chkRoot.Checked = true; }
        }

        private void chkRoot_CheckedChanged(object sender, EventArgs e)
        {
            //chkReader.Checked = !chkReader.Checked;
            //chkRoot.Checked = !chkRoot.Checked;
            if(chkRoot.Checked) { chkReader.Checked = false; }
            else { chkReader.Checked = true; }
        }

        //更新按钮触发事件
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Model.Mod_UserInfo mod_userinfo = new Model.Mod_UserInfo();
            BLL.BLL_UserInfo bll_userinfo = new BLL.BLL_UserInfo();

            mod_userinfo.UserID = txtID.Text;
            mod_userinfo.UserName = txtName.Text;
            mod_userinfo.UserPWD = txtPWD.Text;
            if (chkReader.Checked == true)
            {
                mod_userinfo.UserType = "reader";
            }
            else
            {
                mod_userinfo.UserType = "root";
            }

            //判断修改后的用户信息是否符合规则
            if(bll_userinfo.UserUpdate(mod_userinfo))
            {
                Form form = btnUpdate.FindForm();
                form.Close();
            }
            else
            {
                MessageBox.Show("User ID Wrong!", "Wrong");
            }
        }
    }
}
