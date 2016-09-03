namespace FinalProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.lblDateDue = new System.Windows.Forms.Label();
            this.txtDateDue = new System.Windows.Forms.TextBox();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdUpdateDB = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblComplete = new System.Windows.Forms.Label();
            this.txtComplete = new System.Windows.Forms.TextBox();
            this.txtDateStart = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.radBoth = new System.Windows.Forms.RadioButton();
            this.radY = new System.Windows.Forms.RadioButton();
            this.radN = new System.Windows.Forms.RadioButton();
            this.lblCompStatus = new System.Windows.Forms.Label();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.lblCourseFilter = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTodayDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Organizer";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(173, 371);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name";
            this.lblItemName.Click += new System.EventHandler(this.lblItemName_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(176, 386);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.MaxLength = 20;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(156, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(17, 371);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(43, 13);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course:";
            this.lblCourse.Click += new System.EventHandler(this.lblCourse_Click);
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(17, 386);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourse.MaxLength = 9;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(135, 20);
            this.txtCourse.TabIndex = 0;
            this.txtCourse.TextChanged += new System.EventHandler(this.txtCourse_TextChanged);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(352, 420);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(74, 13);
            this.lblPriority.TabIndex = 5;
            this.lblPriority.Text = "Priority (0 to 9)";
            this.lblPriority.Click += new System.EventHandler(this.lblPriority_Click);
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(362, 435);
            this.txtPriority.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriority.MaxLength = 1;
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(46, 20);
            this.txtPriority.TabIndex = 4;
            this.txtPriority.TextChanged += new System.EventHandler(this.txtPriority_TextChanged);
            // 
            // lblDateDue
            // 
            this.lblDateDue.AutoSize = true;
            this.lblDateDue.Location = new System.Drawing.Point(442, 420);
            this.lblDateDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.Size = new System.Drawing.Size(120, 13);
            this.lblDateDue.TabIndex = 7;
            this.lblDateDue.Text = "Date Due (yyyy/mm/dd)";
            this.lblDateDue.Click += new System.EventHandler(this.lblDateDue_Click);
            // 
            // txtDateDue
            // 
            this.txtDateDue.Location = new System.Drawing.Point(445, 435);
            this.txtDateDue.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateDue.MaxLength = 10;
            this.txtDateDue.Name = "txtDateDue";
            this.txtDateDue.Size = new System.Drawing.Size(104, 20);
            this.txtDateDue.TabIndex = 6;
            this.txtDateDue.TextChanged += new System.EventHandler(this.txtDateDue_TextChanged);
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(17, 486);
            this.cmdInsert.Margin = new System.Windows.Forms.Padding(2);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(112, 30);
            this.cmdInsert.TabIndex = 7;
            this.cmdInsert.Text = "Insert";
            this.cmdInsert.UseVisualStyleBackColor = true;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(143, 486);
            this.cmdUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(112, 30);
            this.cmdUpdate.TabIndex = 8;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(268, 488);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(112, 28);
            this.cmdDelete.TabIndex = 9;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(623, 445);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(2);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(112, 28);
            this.cmdExit.TabIndex = 12;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdUpdateDB
            // 
            this.cmdUpdateDB.Location = new System.Drawing.Point(623, 379);
            this.cmdUpdateDB.Margin = new System.Windows.Forms.Padding(2);
            this.cmdUpdateDB.Name = "cmdUpdateDB";
            this.cmdUpdateDB.Size = new System.Drawing.Size(112, 28);
            this.cmdUpdateDB.TabIndex = 13;
            this.cmdUpdateDB.Text = "Confirm Changes";
            this.cmdUpdateDB.UseVisualStyleBackColor = true;
            this.cmdUpdateDB.Click += new System.EventHandler(this.cmdUpdateDB_Click);
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AllowUserToResizeColumns = false;
            this.dg1.AllowUserToResizeRows = false;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(17, 106);
            this.dg1.Margin = new System.Windows.Forms.Padding(2);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowTemplate.Height = 24;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(718, 249);
            this.dg1.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(17, 420);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(17, 435);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(315, 20);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Location = new System.Drawing.Point(346, 371);
            this.lblComplete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(80, 13);
            this.lblComplete.TabIndex = 19;
            this.lblComplete.Text = "Complete(Y/N):";
            // 
            // txtComplete
            // 
            this.txtComplete.Location = new System.Drawing.Point(362, 386);
            this.txtComplete.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplete.MaxLength = 1;
            this.txtComplete.Name = "txtComplete";
            this.txtComplete.Size = new System.Drawing.Size(46, 20);
            this.txtComplete.TabIndex = 3;
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(445, 387);
            this.txtDateStart.MaxLength = 10;
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.Size = new System.Drawing.Size(104, 20);
            this.txtDateStart.TabIndex = 5;
            this.txtDateStart.TextChanged += new System.EventHandler(this.txtDateStart_TextChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(442, 371);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(122, 13);
            this.lblStartDate.TabIndex = 23;
            this.lblStartDate.Text = "Start Date (yyyy/mm/dd)";
            // 
            // radBoth
            // 
            this.radBoth.AutoSize = true;
            this.radBoth.Checked = true;
            this.radBoth.Location = new System.Drawing.Point(265, 84);
            this.radBoth.Name = "radBoth";
            this.radBoth.Size = new System.Drawing.Size(35, 17);
            this.radBoth.TabIndex = 24;
            this.radBoth.TabStop = true;
            this.radBoth.Text = "All";
            this.radBoth.UseVisualStyleBackColor = true;
            this.radBoth.CheckedChanged += new System.EventHandler(this.radBoth_CheckedChanged);
            // 
            // radY
            // 
            this.radY.AutoSize = true;
            this.radY.Location = new System.Drawing.Point(306, 84);
            this.radY.Name = "radY";
            this.radY.Size = new System.Drawing.Size(42, 17);
            this.radY.TabIndex = 25;
            this.radY.Text = "Yes";
            this.radY.UseVisualStyleBackColor = true;
            this.radY.CheckedChanged += new System.EventHandler(this.radY_CheckedChanged);
            // 
            // radN
            // 
            this.radN.AutoSize = true;
            this.radN.Location = new System.Drawing.Point(354, 84);
            this.radN.Name = "radN";
            this.radN.Size = new System.Drawing.Size(38, 17);
            this.radN.TabIndex = 26;
            this.radN.Text = "No";
            this.radN.UseVisualStyleBackColor = true;
            this.radN.CheckedChanged += new System.EventHandler(this.radN_CheckedChanged);
            // 
            // lblCompStatus
            // 
            this.lblCompStatus.AutoSize = true;
            this.lblCompStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompStatus.Location = new System.Drawing.Point(265, 65);
            this.lblCompStatus.Name = "lblCompStatus";
            this.lblCompStatus.Size = new System.Drawing.Size(99, 13);
            this.lblCompStatus.TabIndex = 27;
            this.lblCompStatus.Text = "Complete Status";
            // 
            // comboCourse
            // 
            this.comboCourse.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboCourse.Location = new System.Drawing.Point(17, 80);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(196, 21);
            this.comboCourse.Sorted = true;
            this.comboCourse.TabIndex = 28;
            this.comboCourse.SelectedIndexChanged += new System.EventHandler(this.comboCourse_SelectedIndexChanged);
            // 
            // lblCourseFilter
            // 
            this.lblCourseFilter.AutoSize = true;
            this.lblCourseFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseFilter.Location = new System.Drawing.Point(17, 65);
            this.lblCourseFilter.Name = "lblCourseFilter";
            this.lblCourseFilter.Size = new System.Drawing.Size(78, 13);
            this.lblCourseFilter.TabIndex = 29;
            this.lblCourseFilter.Text = "Course Filter";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWarning.Location = new System.Drawing.Point(20, 468);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 30;
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(623, 412);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(112, 28);
            this.btnUndo.TabIndex = 31;
            this.btnUndo.Text = "Undo all changes";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Today\'s Date : ";
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Location = new System.Drawing.Point(596, 83);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(28, 13);
            this.lblTodayDate.TabIndex = 33;
            this.lblTodayDate.Text = "date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 527);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblCourseFilter);
            this.Controls.Add(this.comboCourse);
            this.Controls.Add(this.lblCompStatus);
            this.Controls.Add(this.radN);
            this.Controls.Add(this.radY);
            this.Controls.Add(this.radBoth);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtDateStart);
            this.Controls.Add(this.txtComplete);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.cmdUpdateDB);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdInsert);
            this.Controls.Add(this.txtDateDue);
            this.Controls.Add(this.lblDateDue);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Final C# Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label lblDateDue;
        private System.Windows.Forms.TextBox txtDateDue;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdUpdateDB;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.TextBox txtComplete;
        private System.Windows.Forms.TextBox txtDateStart;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.RadioButton radBoth;
        private System.Windows.Forms.RadioButton radY;
        private System.Windows.Forms.RadioButton radN;
        private System.Windows.Forms.Label lblCompStatus;
        private System.Windows.Forms.ComboBox comboCourse;
        private System.Windows.Forms.Label lblCourseFilter;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTodayDate;
    }
}

