namespace UIApplication
{
    partial class FormAddGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddGroup));
            this.labelGroupname = new System.Windows.Forms.Label();
            this.textBoxGroupname = new System.Windows.Forms.TextBox();
            this.textBoxProfession = new System.Windows.Forms.TextBox();
            this.labelProfession = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelSemester = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.labelStudents = new System.Windows.Forms.Label();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.listBoxTeachers = new System.Windows.Forms.ListBox();
            this.labelTeachers = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGroupname
            // 
            this.labelGroupname.AutoSize = true;
            this.labelGroupname.Location = new System.Drawing.Point(12, 9);
            this.labelGroupname.Name = "labelGroupname";
            this.labelGroupname.Size = new System.Drawing.Size(68, 13);
            this.labelGroupname.TabIndex = 0;
            this.labelGroupname.Text = "Group name:";
            // 
            // textBoxGroupname
            // 
            this.textBoxGroupname.Location = new System.Drawing.Point(86, 6);
            this.textBoxGroupname.Name = "textBoxGroupname";
            this.textBoxGroupname.Size = new System.Drawing.Size(195, 20);
            this.textBoxGroupname.TabIndex = 1;
            // 
            // textBoxProfession
            // 
            this.textBoxProfession.Location = new System.Drawing.Point(86, 32);
            this.textBoxProfession.Name = "textBoxProfession";
            this.textBoxProfession.Size = new System.Drawing.Size(195, 20);
            this.textBoxProfession.TabIndex = 3;
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Location = new System.Drawing.Point(12, 35);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(59, 13);
            this.labelProfession.TabIndex = 2;
            this.labelProfession.Text = "Profession:";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(12, 61);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(38, 13);
            this.labelHours.TabIndex = 4;
            this.labelHours.Text = "Hours:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(86, 58);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(12, 87);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(54, 13);
            this.labelSemester.TabIndex = 6;
            this.labelSemester.Text = "Semester:";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(86, 84);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(195, 21);
            this.comboBoxSemester.TabIndex = 7;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Location = new System.Drawing.Point(12, 114);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(52, 13);
            this.labelStudents.TabIndex = 8;
            this.labelStudents.Text = "Students:";
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(86, 114);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(195, 95);
            this.listBoxStudents.TabIndex = 9;
            // 
            // listBoxTeachers
            // 
            this.listBoxTeachers.FormattingEnabled = true;
            this.listBoxTeachers.Location = new System.Drawing.Point(86, 215);
            this.listBoxTeachers.Name = "listBoxTeachers";
            this.listBoxTeachers.Size = new System.Drawing.Size(195, 95);
            this.listBoxTeachers.TabIndex = 11;
            // 
            // labelTeachers
            // 
            this.labelTeachers.AutoSize = true;
            this.labelTeachers.Location = new System.Drawing.Point(12, 215);
            this.labelTeachers.Name = "labelTeachers";
            this.labelTeachers.Size = new System.Drawing.Size(55, 13);
            this.labelTeachers.TabIndex = 10;
            this.labelTeachers.Text = "Teachers:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(15, 316);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 32);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(109, 316);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 32);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(206, 316);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 32);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 360);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxTeachers);
            this.Controls.Add(this.labelTeachers);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.textBoxProfession);
            this.Controls.Add(this.labelProfession);
            this.Controls.Add(this.textBoxGroupname);
            this.Controls.Add(this.labelGroupname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddGroup";
            this.Text = "FormAddGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGroupname;
        private System.Windows.Forms.TextBox textBoxGroupname;
        private System.Windows.Forms.TextBox textBoxProfession;
        private System.Windows.Forms.Label labelProfession;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.ListBox listBoxTeachers;
        private System.Windows.Forms.Label labelTeachers;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}