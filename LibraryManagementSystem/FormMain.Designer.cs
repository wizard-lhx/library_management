namespace LibraryManagementSystem
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panSwitchWin = new System.Windows.Forms.Panel();
            this.panWin = new System.Windows.Forms.Panel();
            this.panBtn = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSwitchWin
            // 
            this.panSwitchWin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSwitchWin.Location = new System.Drawing.Point(0, 0);
            this.panSwitchWin.Name = "panSwitchWin";
            this.panSwitchWin.Size = new System.Drawing.Size(82, 450);
            this.panSwitchWin.TabIndex = 0;
            // 
            // panWin
            // 
            this.panWin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panWin.Location = new System.Drawing.Point(82, 0);
            this.panWin.Name = "panWin";
            this.panWin.Size = new System.Drawing.Size(718, 401);
            this.panWin.TabIndex = 1;
            // 
            // panBtn
            // 
            this.panBtn.Controls.Add(this.btnDelete);
            this.panBtn.Controls.Add(this.btnInsert);
            this.panBtn.Controls.Add(this.btnModify);
            this.panBtn.Controls.Add(this.btnView);
            this.panBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBtn.Location = new System.Drawing.Point(82, 407);
            this.panBtn.Name = "panBtn";
            this.panBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panBtn.Size = new System.Drawing.Size(718, 43);
            this.panBtn.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(32, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(184, 8);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(164, 27);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(354, 8);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(164, 27);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Update";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(524, 8);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(182, 27);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "List View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panBtn);
            this.Controls.Add(this.panWin);
            this.Controls.Add(this.panSwitchWin);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panSwitchWin;
        private Panel panWin;
        private Panel panBtn;
        private Button btnDelete;
        private Button btnInsert;
        private Button btnModify;
        private Button btnView;
    }
}