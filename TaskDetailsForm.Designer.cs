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
            this.SuspendLayout();
            // 
            // lblTaskNameDetails
            // 
            this.lblTaskNameDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTaskNameDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblTaskNameDetails.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskNameDetails.ForeColor = System.Drawing.Color.White;
            this.lblTaskNameDetails.Location = new System.Drawing.Point(12, 9);
            this.lblTaskNameDetails.Name = "lblTaskNameDetails";
            this.lblTaskNameDetails.Size = new System.Drawing.Size(644, 50);
            this.lblTaskNameDetails.TabIndex = 0;
            this.lblTaskNameDetails.Text = "Task";
            this.lblTaskNameDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prgTaskCompletion
            // 
            this.prgTaskCompletion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.prgTaskCompletion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.prgTaskCompletion.Location = new System.Drawing.Point(13, 252);
            this.prgTaskCompletion.MarqueeAnimationSpeed = 500;
            this.prgTaskCompletion.Name = "prgTaskCompletion";
            this.prgTaskCompletion.Size = new System.Drawing.Size(316, 40);
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
            this.lblDescriptionDetails.Location = new System.Drawing.Point(12, 62);
            this.lblDescriptionDetails.Name = "lblDescriptionDetails";
            this.lblDescriptionDetails.Size = new System.Drawing.Size(317, 40);
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
            this.rtxtDescriptionDetails.Location = new System.Drawing.Point(13, 106);
            this.rtxtDescriptionDetails.Name = "rtxtDescriptionDetails";
            this.rtxtDescriptionDetails.ReadOnly = true;
            this.rtxtDescriptionDetails.Size = new System.Drawing.Size(316, 140);
            this.rtxtDescriptionDetails.TabIndex = 3;
            this.rtxtDescriptionDetails.Text = "";
            // 
            // lblPriorityDetails
            // 
            this.lblPriorityDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPriorityDetails.BackColor = System.Drawing.Color.White;
            this.lblPriorityDetails.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblPriorityDetails.Location = new System.Drawing.Point(335, 252);
            this.lblPriorityDetails.Name = "lblPriorityDetails";
            this.lblPriorityDetails.Size = new System.Drawing.Size(321, 40);
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
            this.lblPriorityLevel.Location = new System.Drawing.Point(591, 252);
            this.lblPriorityLevel.Name = "lblPriorityLevel";
            this.lblPriorityLevel.Size = new System.Drawing.Size(65, 40);
            this.lblPriorityLevel.TabIndex = 5;
            this.lblPriorityLevel.Text = "0";
            this.lblPriorityLevel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // mCalenderDetails
            // 
            this.mCalenderDetails.Location = new System.Drawing.Point(13, 304);
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
            this.lblPlace.Location = new System.Drawing.Point(335, 62);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(321, 40);
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
            this.rtxtPlaceDetails.Location = new System.Drawing.Point(335, 106);
            this.rtxtPlaceDetails.Name = "rtxtPlaceDetails";
            this.rtxtPlaceDetails.ReadOnly = true;
            this.rtxtPlaceDetails.Size = new System.Drawing.Size(321, 140);
            this.rtxtPlaceDetails.TabIndex = 8;
            this.rtxtPlaceDetails.Text = "";
            // 
            // TaskDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(668, 575);
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
    }
}