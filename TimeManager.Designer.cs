namespace TimeManager
{
    partial class TimeManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.dGTaskView = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPriority = new System.Windows.Forms.NumericUpDown();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.cBoxPeople = new System.Windows.Forms.ComboBox();
            this.cBoxTaskType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.dateTimeInput = new System.Windows.Forms.DateTimePicker();
            this.TimeSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGTaskView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDo.Location = new System.Drawing.Point(90, 9);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(145, 24);
            this.lblToDo.TabIndex = 0;
            this.lblToDo.Text = "Time Manager";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(12, 78);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(121, 24);
            this.lblTaskName.TabIndex = 1;
            this.lblTaskName.Text = "Task Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 123);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(121, 24);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(12, 203);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(80, 24);
            this.lblPriority.TabIndex = 3;
            this.lblPriority.Text = "Priority:";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(12, 245);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(68, 24);
            this.lblPlace.TabIndex = 4;
            this.lblPlace.Text = "Place:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(141, 81);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(185, 20);
            this.txtTaskName.TabIndex = 5;
            this.txtTaskName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(141, 128);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(185, 61);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(141, 250);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(185, 20);
            this.txtPlace.TabIndex = 8;
            this.txtPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddTask
            // 
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnAddTask.FlatAppearance.BorderSize = 5;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnAddTask.Location = new System.Drawing.Point(17, 377);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(298, 37);
            this.btnAddTask.TabIndex = 9;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditTask.FlatAppearance.BorderSize = 5;
            this.btnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTask.ForeColor = System.Drawing.Color.Yellow;
            this.btnEditTask.Location = new System.Drawing.Point(17, 421);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(146, 37);
            this.btnEditTask.TabIndex = 10;
            this.btnEditTask.Text = "Edit Task";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(86)))), ((int)(((byte)(82)))));
            this.btnRemoveTask.FlatAppearance.BorderSize = 5;
            this.btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))));
            this.btnRemoveTask.Location = new System.Drawing.Point(170, 421);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(146, 37);
            this.btnRemoveTask.TabIndex = 11;
            this.btnRemoveTask.Text = "Remove Task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // dGTaskView
            // 
            this.dGTaskView.AllowUserToAddRows = false;
            this.dGTaskView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dGTaskView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGTaskView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGTaskView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGTaskView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGTaskView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.Description,
            this.Priority,
            this.Place,
            this.Deadline,
            this.Type,
            this.TimeSpent});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGTaskView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGTaskView.Dock = System.Windows.Forms.DockStyle.Right;
            this.dGTaskView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.dGTaskView.Location = new System.Drawing.Point(373, 0);
            this.dGTaskView.Name = "dGTaskView";
            this.dGTaskView.ReadOnly = true;
            this.dGTaskView.RowHeadersWidth = 51;
            this.dGTaskView.Size = new System.Drawing.Size(908, 485);
            this.dGTaskView.TabIndex = 13;
            this.dGTaskView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGTaskView_CellClick);
            this.dGTaskView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGTaskView_CellDoubleClick);
            // 
            // Task
            // 
            this.Task.HeaderText = "Task";
            this.Task.MinimumWidth = 6;
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            this.Task.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Width = 125;
            // 
            // Place
            // 
            this.Place.HeaderText = "Place";
            this.Place.MinimumWidth = 6;
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            this.Place.Width = 125;
            // 
            // Deadline
            // 
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.MinimumWidth = 6;
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            this.Deadline.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // numPriority
            // 
            this.numPriority.Location = new System.Drawing.Point(141, 209);
            this.numPriority.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPriority.Name = "numPriority";
            this.numPriority.Size = new System.Drawing.Size(185, 20);
            this.numPriority.TabIndex = 14;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(12, 282);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(99, 24);
            this.lblDeadline.TabIndex = 15;
            this.lblDeadline.Text = "Deadline:";
            // 
            // cBoxPeople
            // 
            this.cBoxPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.cBoxPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPeople.ForeColor = System.Drawing.Color.White;
            this.cBoxPeople.FormattingEnabled = true;
            this.cBoxPeople.IntegralHeight = false;
            this.cBoxPeople.ItemHeight = 17;
            this.cBoxPeople.Location = new System.Drawing.Point(78, 35);
            this.cBoxPeople.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxPeople.Name = "cBoxPeople";
            this.cBoxPeople.Size = new System.Drawing.Size(180, 25);
            this.cBoxPeople.TabIndex = 17;
            this.cBoxPeople.SelectedIndexChanged += new System.EventHandler(this.cBoxPeople_SelectedIndexChanged);
            // 
            // cBoxTaskType
            // 
            this.cBoxTaskType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.cBoxTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTaskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTaskType.ForeColor = System.Drawing.Color.White;
            this.cBoxTaskType.FormattingEnabled = true;
            this.cBoxTaskType.Location = new System.Drawing.Point(140, 323);
            this.cBoxTaskType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxTaskType.Name = "cBoxTaskType";
            this.cBoxTaskType.Size = new System.Drawing.Size(186, 25);
            this.cBoxTaskType.TabIndex = 18;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(12, 319);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 24);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Type:";
            // 
            // dateTimeInput
            // 
            this.dateTimeInput.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.dateTimeInput.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.dateTimeInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimeInput.CustomFormat = "dd/MM/yyyy";
            this.dateTimeInput.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimeInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInput.Location = new System.Drawing.Point(141, 286);
            this.dateTimeInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeInput.Name = "dateTimeInput";
            this.dateTimeInput.Size = new System.Drawing.Size(185, 20);
            this.dateTimeInput.TabIndex = 20;
            this.dateTimeInput.Value = new System.DateTime(2023, 1, 19, 13, 38, 46, 0);
            // 
            // TimeSpent
            // 
            this.TimeSpent.HeaderText = "TimeSpent";
            this.TimeSpent.Name = "TimeSpent";
            this.TimeSpent.ReadOnly = true;
            // 
            // TimeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1281, 485);
            this.Controls.Add(this.dateTimeInput);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cBoxTaskType);
            this.Controls.Add(this.cBoxPeople);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.numPriority);
            this.Controls.Add(this.dGTaskView);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblToDo);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "TimeManager";
            this.Text = "TimeManager";
            this.Load += new System.EventHandler(this.TimeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGTaskView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.DataGridView dGTaskView;
        private System.Windows.Forms.NumericUpDown numPriority;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.ComboBox cBoxPeople;
        private System.Windows.Forms.ComboBox cBoxTaskType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        public System.Windows.Forms.DateTimePicker dateTimeInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSpent;
    }
}

