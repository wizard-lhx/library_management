namespace LibraryManagementSystem
{
    partial class ControlWin_ListUserInfo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstView = new System.Windows.Forms.ListView();
            this.userID = new System.Windows.Forms.ColumnHeader();
            this.userName = new System.Windows.Forms.ColumnHeader();
            this.userPWD = new System.Windows.Forms.ColumnHeader();
            this.userType = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lstView
            // 
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userID,
            this.userName,
            this.userPWD,
            this.userType});
            this.lstView.FullRowSelect = true;
            this.lstView.GridLines = true;
            this.lstView.Location = new System.Drawing.Point(-3, 1);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(718, 400);
            this.lstView.TabIndex = 1;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            // 
            // userID
            // 
            this.userID.Text = "UserID";
            this.userID.Width = 200;
            // 
            // userName
            // 
            this.userName.Text = "UserName";
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userName.Width = 150;
            // 
            // userPWD
            // 
            this.userPWD.Text = "UserPWD";
            this.userPWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userPWD.Width = 200;
            // 
            // userType
            // 
            this.userType.Text = "UserType";
            this.userType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userType.Width = 160;
            // 
            // ControlWin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstView);
            this.Name = "ControlWin1";
            this.Size = new System.Drawing.Size(718, 401);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lstView;
        private ColumnHeader userID;
        private ColumnHeader userName;
        private ColumnHeader userPWD;
        private ColumnHeader userType;
    }
}
