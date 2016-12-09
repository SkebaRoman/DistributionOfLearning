namespace UIApplication
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAudiencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semestersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(527, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newGroupToolStripMenuItem,
            this.newStudentToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New audience";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newGroupToolStripMenuItem
            // 
            this.newGroupToolStripMenuItem.Name = "newGroupToolStripMenuItem";
            this.newGroupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGroupToolStripMenuItem.Text = "New group";
            this.newGroupToolStripMenuItem.Click += new System.EventHandler(this.newGroupToolStripMenuItem_Click);
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newStudentToolStripMenuItem.Text = "New student";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.newStudentToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAudiencesToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.semestersToolStripMenuItem,
            this.computersToolStripMenuItem,
            this.softwaresToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editAudiencesToolStripMenuItem
            // 
            this.editAudiencesToolStripMenuItem.Name = "editAudiencesToolStripMenuItem";
            this.editAudiencesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editAudiencesToolStripMenuItem.Text = "Audiences";
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.teachersToolStripMenuItem.Text = "Teachers";
            // 
            // semestersToolStripMenuItem
            // 
            this.semestersToolStripMenuItem.Name = "semestersToolStripMenuItem";
            this.semestersToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.semestersToolStripMenuItem.Text = "Semesters";
            // 
            // computersToolStripMenuItem
            // 
            this.computersToolStripMenuItem.Name = "computersToolStripMenuItem";
            this.computersToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.computersToolStripMenuItem.Text = "Computers";
            // 
            // softwaresToolStripMenuItem
            // 
            this.softwaresToolStripMenuItem.Name = "softwaresToolStripMenuItem";
            this.softwaresToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.softwaresToolStripMenuItem.Text = "Softwares";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 317);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "GENERATE SCHEDULE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Main";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAudiencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semestersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwaresToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}

