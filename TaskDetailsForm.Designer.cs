namespace TimeManager
{
    partial class TaskDetailsForm
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
            this.lblTaskNameDetails = new System.Windows.Forms.Label();
            this.prgTaskCompletion = new System.Windows.Forms.ProgressBar();
            this.lblDescriptionDetails = new System.Windows.Forms.Label();
            this.rtxtDescriptionDetails = new System.Windows.Forms.RichTextBox();
            this.lblPriorityDetails = new System.Windows.Forms.Label();
            this.lblPriorityLevel = new System.Windows.Forms.Label();
            this.mCalenderDetails = new System.Windows.Forms.MonthCalendar();
            this.lblPlace = new System.Windows.Forms.Label();
            this.rtxtPlaceDetails = new System.Windows.Forms.RichTextBox();
            this.lblTimeSpent = new System.Windows.Forms.Label();
            this.lblTimeSpentTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTaskNameDetails
            // 
            this.lblTaskNameDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTaskNameDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblTaskNameDetails.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskNameDetails.ForeColor = System.Drawing.Color.White;
            this.lblTaskNameDetails.Location = new System.Drawing.Point(9, 7);
            this.lblTaskNameDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskNameDetails.Name = "lblTaskNameDetails";
            this.lblTaskNameDetails.Size = new System.Drawing.Size(483, 41);
            this.lblTaskNameDetails.TabIndex = 0;
            this.lblTaskNameDetails.Text = "Task";
            this.lblTaskNameDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prgTaskCompletion
            // 
            this.prgTaskCompletion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.prgTaskCompletion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.prgTaskCompletion.Location = new System.Drawing.Point(10, 205);
            this.prgTaskCompletion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prgTaskCompletion.MarqueeAnimationSpeed = 500;
            this.prgTaskCompletion.Name = "prgTaskCompletion";
            this.prgTaskCompletion.Size = new System.Drawing.Size(237, 32);
            this.prgTaskCompletion.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgTaskCompletion.TabIndex = 1;
            this.prgTaskCompletion.Value = 20;
            // 
            // lblDescriptionDetails
            // 
            this.lblDescriptionDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDescriptionDetails.BackColor = System.Drawing.Color.White;
            this.lblDescriptionDetails.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblDescriptionDetails.Location = new System.Drawing.Point(9, 50);
            this.lblDescriptionDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriptionDetails.Name = "lblDescriptionDetails";
            this.lblDescriptionDetails.Size = new System.Drawing.Size(238, 32);
            this.lblDescriptionDetails.TabIndex = 2;
            this.lblDescriptionDetails.Text = "Description";
            this.lblDescriptionDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtDescriptionDetails
            // 
            this.rtxtDescriptionDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.rtxtDescriptionDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtxtDescriptionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescriptionDetails.ForeColor = System.Drawing.Color.White;
            this.rtxtDescriptionDetails.Location = new System.Drawing.Point(10, 86);
            this.rtxtDescriptionDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtDescriptionDetails.Name = "rtxtDescriptionDetails";
            this.rtxtDescriptionDetails.ReadOnly = true;
            this.rtxtDescriptionDetails.Size = new System.Drawing.Size(238, 114);
            this.rtxtDescriptionDetails.TabIndex = 3;
            this.rtxtDescriptionDetails.Text = "";
            // 
            // lblPriorityDetails
            // 
            this.lblPriorityDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPriorityDetails.BackColor = System.Drawing.Color.White;
            this.lblPriorityDetails.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblPriorityDetails.Location = new System.Drawing.Point(251, 205);
            this.lblPriorityDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriorityDetails.Name = "lblPriorityDetails";
            this.lblPriorityDetails.Size = new System.Drawing.Size(214, 32);
            this.lblPriorityDetails.TabIndex = 4;
            this.lblPriorityDetails.Text = "Priority Level :";
            this.lblPriorityDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriorityLevel
            // 
            this.lblPriorityLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPriorityLevel.BackColor = System.Drawing.Color.White;
            this.lblPriorityLevel.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblPriorityLevel.Location = new System.Drawing.Point(451, 205);
            this.lblPriorityLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriorityLevel.Name = "lblPriorityLevel";
            this.lblPriorityLevel.Size = new System.Drawing.Size(41, 32);
            this.lblPriorityLevel.TabIndex = 5;
            this.lblPriorityLevel.Text = "0";
            this.lblPriorityLevel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // mCalenderDetails
            // 
            this.mCalenderDetails.Location = new System.Drawing.Point(10, 247);
            this.mCalenderDetails.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mCalenderDetails.MaxSelectionCount = 365;
            this.mCalenderDetails.Name = "mCalenderDetails";
            this.mCalenderDetails.TabIndex = 6;
            // 
            // lblPlace
            // 
            this.lblPlace.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPlace.BackColor = System.Drawing.Color.White;
            this.lblPlace.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblPlace.Location = new System.Drawing.Point(251, 50);
            this.lblPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(241, 32);
            this.lblPlace.TabIndex = 7;
            this.lblPlace.Text = "Place";
            this.lblPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtPlaceDetails
            // 
            this.rtxtPlaceDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.rtxtPlaceDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtxtPlaceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtPlaceDetails.ForeColor = System.Drawing.Color.White;
            this.rtxtPlaceDetails.Location = new System.Drawing.Point(251, 86);
            this.rtxtPlaceDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtPlaceDetails.Name = "rtxtPlaceDetails";
            this.rtxtPlaceDetails.ReadOnly = true;
            this.rtxtPlaceDetails.Size = new System.Drawing.Size(242, 114);
            this.rtxtPlaceDetails.TabIndex = 8;
            this.rtxtPlaceDetails.Text = "";
            // 
            // lblTimeSpent
            // 
            this.lblTimeSpent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimeSpent.BackColor = System.Drawing.Color.White;
            this.lblTimeSpent.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblTimeSpent.Location = new System.Drawing.Point(416, 247);
            this.lblTimeSpent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeSpent.Name = "lblTimeSpent";
            this.lblTimeSpent.Size = new System.Drawing.Size(76, 32);
            this.lblTimeSpent.TabIndex = 10;
            this.lblTimeSpent.Text = "0";
            this.lblTimeSpent.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTimeSpentTxt
            // 
            this.lblTimeSpentTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimeSpentTxt.BackColor = System.Drawing.Color.White;
            this.lblTimeSpentTxt.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSpentTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblTimeSpentTxt.Location = new System.Drawing.Point(251, 247);
            this.lblTimeSpentTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeSpentTxt.Name = "lblTimeSpentTxt";
            this.lblTimeSpentTxt.Size = new System.Drawing.Size(196, 32);
            this.lblTimeSpentTxt.TabIndex = 9;
            this.lblTimeSpentTxt.Text = "Time Spent :";
            this.lblTimeSpentTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(501, 467);
            this.Controls.Add(this.lblTimeSpent);
            this.Controls.Add(this.lblTimeSpentTxt);
            this.Controls.Add(this.rtxtPlaceDetails);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.mCalenderDetails);
            this.Controls.Add(this.lblPriorityLevel);
            this.Controls.Add(this.lblPriorityDetails);
            this.Controls.Add(this.rtxtDescriptionDetails);
            this.Controls.Add(this.lblDescriptionDetails);
            this.Controls.Add(this.prgTaskCompletion);
            this.Controls.Add(this.lblTaskNameDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Task Details";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblTaskNameDetails;
        public System.Windows.Forms.ProgressBar prgTaskCompletion;
        public System.Windows.Forms.Label lblDescriptionDetails;
        public System.Windows.Forms.RichTextBox rtxtDescriptionDetails;
        public System.Windows.Forms.Label lblPriorityDetails;
        public System.Windows.Forms.Label lblPriorityLevel;
        public System.Windows.Forms.MonthCalendar mCalenderDetails;
        public System.Windows.Forms.Label lblPlace;
        public System.Windows.Forms.RichTextBox rtxtPlaceDetails;
        public System.Windows.Forms.Label lblTimeSpent;
        public System.Windows.Forms.Label lblTimeSpentTxt;
    }
}