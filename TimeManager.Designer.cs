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
            this.numPriority = new System.Windows.Forms.NumericUpDown();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.cBoxPeople = new System.Windows.Forms.ComboBox();
            this.cBoxTaskType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGTaskView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDo.Location = new System.Drawing.Point(120, 11);
            this.lblToDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(182, 29);
            this.lblToDo.TabIndex = 0;
            this.lblToDo.Text = "Time Manager";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(16, 96);
            this.lblTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(153, 29);
            this.lblTaskName.TabIndex = 1;
            this.lblTaskName.Text = "Task Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(16, 151);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(153, 29);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(16, 250);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(103, 29);
            this.lblPriority.TabIndex = 3;
            this.lblPriority.Text = "Priority:";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(16, 309);
            this.lblPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(86, 29);
            this.lblPlace.TabIndex = 4;
            this.lblPlace.Text = "Place:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(208, 100);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(225, 22);
            this.txtTaskName.TabIndex = 5;
            this.txtTaskName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(208, 158);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(225, 74);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(208, 315);
            this.txtPlace.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(225, 22);
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
            this.btnAddTask.Location = new System.Drawing.Point(21, 477);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(195, 46);
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
            this.btnEditTask.Location = new System.Drawing.Point(240, 477);
            this.btnEditTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(195, 46);
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
            this.btnRemoveTask.Location = new System.Drawing.Point(125, 544);
            this.btnRemoveTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(195, 46);
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
            this.Type});
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
            this.dGTaskView.Location = new System.Drawing.Point(464, 0);
            this.dGTaskView.Margin = new System.Windows.Forms.Padding(4);
            this.dGTaskView.Name = "dGTaskView";
            this.dGTaskView.ReadOnly = true;
            this.dGTaskView.RowHeadersWidth = 51;
            this.dGTaskView.Size = new System.Drawing.Size(914, 676);
            this.dGTaskView.TabIndex = 13;
            // 
            // numPriority
            // 
            this.numPriority.Location = new System.Drawing.Point(208, 257);
            this.numPriority.Margin = new System.Windows.Forms.Padding(4);
            this.numPriority.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPriority.Name = "numPriority";
            this.numPriority.Size = new System.Drawing.Size(227, 22);
            this.numPriority.TabIndex = 14;
            // 
            // txtDeadline
            // 
            this.txtDeadline.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDeadline.Location = new System.Drawing.Point(210, 364);
            this.txtDeadline.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(225, 22);
            this.txtDeadline.TabIndex = 16;
            this.txtDeadline.Text = "dd-mm-yyyy";
            this.txtDeadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeadline.Click += new System.EventHandler(this.txtDeadline_Click);
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(18, 358);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(125, 29);
            this.lblDeadline.TabIndex = 15;
            this.lblDeadline.Text = "Deadline:";
            // 
            // cBoxPeople
            // 
            this.cBoxPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.cBoxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPeople.ForeColor = System.Drawing.Color.White;
            this.cBoxPeople.FormattingEnabled = true;
            this.cBoxPeople.Location = new System.Drawing.Point(23, 624);
            this.cBoxPeople.Name = "cBoxPeople";
            this.cBoxPeople.Size = new System.Drawing.Size(238, 28);
            this.cBoxPeople.TabIndex = 17;
            this.cBoxPeople.Text = "People";
            // 
            // cBoxTaskType
            // 
            this.cBoxTaskType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.cBoxTaskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTaskType.ForeColor = System.Drawing.Color.White;
            this.cBoxTaskType.FormattingEnabled = true;
            this.cBoxTaskType.Location = new System.Drawing.Point(208, 408);
            this.cBoxTaskType.Name = "cBoxTaskType";
            this.cBoxTaskType.Size = new System.Drawing.Size(227, 28);
            this.cBoxTaskType.TabIndex = 18;
            this.cBoxTaskType.Text = "Task Type";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(18, 408);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(79, 29);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Type:";
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
            // TimeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1378, 676);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cBoxTaskType);
            this.Controls.Add(this.cBoxPeople);
            this.Controls.Add(this.txtDeadline);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtDeadline;
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
    }
}

