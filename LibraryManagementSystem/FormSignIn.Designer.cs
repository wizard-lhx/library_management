namespace LibraryManager
{
    partial class FormSignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labUserID = new System.Windows.Forms.Label();
            this.labPWD = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxUserPWD = new System.Windows.Forms.TextBox();
            this.labSignIn = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.chkBoxReader = new System.Windows.Forms.CheckBox();
            this.chkBoxRoot = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labUserID
            // 
            this.labUserID.AutoSize = true;
            this.labUserID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labUserID.Location = new System.Drawing.Point(193, 149);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(79, 25);
            this.labUserID.TabIndex = 0;
            this.labUserID.Text = "User ID";
            // 
            // labPWD
            // 
            this.labPWD.AutoSize = true;
            this.labPWD.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labPWD.Location = new System.Drawing.Point(193, 215);
            this.labPWD.Name = "labPWD";
            this.labPWD.Size = new System.Drawing.Size(146, 25);
            this.labPWD.TabIndex = 1;
            this.labPWD.Text = "User Password";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(369, 149);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(185, 23);
            this.textBoxUserID.TabIndex = 2;
            // 
            // textBoxUserPWD
            // 
            this.textBoxUserPWD.Location = new System.Drawing.Point(369, 215);
            this.textBoxUserPWD.Name = "textBoxUserPWD";
            this.textBoxUserPWD.Size = new System.Drawing.Size(185, 23);
            this.textBoxUserPWD.TabIndex = 3;
            // 
            // labSignIn
            // 
            this.labSignIn.AutoSize = true;
            this.labSignIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labSignIn.Location = new System.Drawing.Point(170, 49);
            this.labSignIn.Name = "labSignIn";
            this.labSignIn.Size = new System.Drawing.Size(450, 28);
            this.labSignIn.TabIndex = 4;
            this.labSignIn.Text = "Welcome to Library Management System";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignIn.Location = new System.Drawing.Point(280, 333);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(215, 37);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // chkBoxReader
            // 
            this.chkBoxReader.AutoSize = true;
            this.chkBoxReader.Checked = true;
            this.chkBoxReader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxReader.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBoxReader.Location = new System.Drawing.Point(254, 275);
            this.chkBoxReader.Name = "chkBoxReader";
            this.chkBoxReader.Size = new System.Drawing.Size(75, 24);
            this.chkBoxReader.TabIndex = 6;
            this.chkBoxReader.Text = "Reader";
            this.chkBoxReader.UseVisualStyleBackColor = true;
            this.chkBoxReader.CheckedChanged += new System.EventHandler(this.chkBoxReader_CheckedChanged);
            // 
            // chkBoxRoot
            // 
            this.chkBoxRoot.AutoSize = true;
            this.chkBoxRoot.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBoxRoot.Location = new System.Drawing.Point(442, 275);
            this.chkBoxRoot.Name = "chkBoxRoot";
            this.chkBoxRoot.Size = new System.Drawing.Size(60, 24);
            this.chkBoxRoot.TabIndex = 7;
            this.chkBoxRoot.Text = "Root";
            this.chkBoxRoot.UseVisualStyleBackColor = true;
            this.chkBoxRoot.CheckedChanged += new System.EventHandler(this.chkBoxRoot_CheckedChanged);
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkBoxRoot);
            this.Controls.Add(this.chkBoxReader);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.labSignIn);
            this.Controls.Add(this.textBoxUserPWD);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.labPWD);
            this.Controls.Add(this.labUserID);
            this.MaximizeBox = false;
            this.Name = "FormSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.FormSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labUserID;
        private Label labPWD;
        private TextBox textBoxUserID;
        private TextBox textBoxUserPWD;
        private Label labSignIn;
        private Button btnSignIn;
        private CheckBox chkBoxReader;
        private CheckBox chkBoxRoot;
    }
}