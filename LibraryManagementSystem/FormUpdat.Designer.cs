namespace LibraryManagementSystem
{
    partial class FormUpdat
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labPWD = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.chkReader = new System.Windows.Forms.CheckBox();
            this.chkRoot = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(299, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 40);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labName.Location = new System.Drawing.Point(241, 152);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(51, 19);
            this.labName.TabIndex = 2;
            this.labName.Text = "Name";
            // 
            // labPWD
            // 
            this.labPWD.AutoSize = true;
            this.labPWD.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPWD.Location = new System.Drawing.Point(241, 235);
            this.labPWD.Name = "labPWD";
            this.labPWD.Size = new System.Drawing.Size(76, 19);
            this.labPWD.TabIndex = 3;
            this.labPWD.Text = "Password";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(339, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(143, 23);
            this.txtID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(339, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(339, 229);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(143, 23);
            this.txtPWD.TabIndex = 6;
            // 
            // chkReader
            // 
            this.chkReader.AutoSize = true;
            this.chkReader.Checked = true;
            this.chkReader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReader.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkReader.Location = new System.Drawing.Point(241, 310);
            this.chkReader.Name = "chkReader";
            this.chkReader.Size = new System.Drawing.Size(75, 24);
            this.chkReader.TabIndex = 7;
            this.chkReader.Text = "Reader";
            this.chkReader.UseVisualStyleBackColor = true;
            this.chkReader.CheckedChanged += new System.EventHandler(this.chkReader_CheckedChanged);
            // 
            // chkRoot
            // 
            this.chkRoot.AutoSize = true;
            this.chkRoot.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRoot.Location = new System.Drawing.Point(478, 310);
            this.chkRoot.Name = "chkRoot";
            this.chkRoot.Size = new System.Drawing.Size(60, 24);
            this.chkRoot.TabIndex = 8;
            this.chkRoot.Text = "Root";
            this.chkRoot.UseVisualStyleBackColor = true;
            this.chkRoot.CheckedChanged += new System.EventHandler(this.chkRoot_CheckedChanged);
            // 
            // FormUpdat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkRoot);
            this.Controls.Add(this.chkReader);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labPWD);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.MaximizeBox = false;
            this.Name = "FormUpdat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Account";
            this.Load += new System.EventHandler(this.FormUpdat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private Label label1;
        private Label labName;
        private Label labPWD;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPWD;
        private CheckBox chkReader;
        private CheckBox chkRoot;
    }
}