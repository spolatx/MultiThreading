namespace MultiThreadingExample
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            btnListMailTasks = new Button();
            lblLogs = new ListBox();
            dataGridView1 = new DataGridView();
            mailTaskBindingSource = new BindingSource(components);
            btnStart = new Button();
            btnStop = new Button();
            btnRun = new Button();
            groupBox1 = new GroupBox();
            taskIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ısRunningDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ısStartedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            secondDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nextRunningDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnListMailTasks
            // 
            btnListMailTasks.Location = new Point(12, 12);
            btnListMailTasks.Name = "btnListMailTasks";
            btnListMailTasks.Size = new Size(836, 66);
            btnListMailTasks.TabIndex = 0;
            btnListMailTasks.Text = "List Mail Tasks";
            btnListMailTasks.UseVisualStyleBackColor = true;
            btnListMailTasks.Click += btnListMailTasks_Click;
            // 
            // lblLogs
            // 
            lblLogs.BackColor = SystemColors.ControlDark;
            lblLogs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogs.FormattingEnabled = true;
            lblLogs.ItemHeight = 20;
            lblLogs.Location = new Point(12, 354);
            lblLogs.Name = "lblLogs";
            lblLogs.Size = new Size(836, 144);
            lblLogs.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { taskIdDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, ısRunningDataGridViewCheckBoxColumn, ısStartedDataGridViewCheckBoxColumn, secondDataGridViewTextBoxColumn, nextRunningDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mailTaskBindingSource;
            dataGridView1.Location = new Point(12, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(836, 135);
            dataGridView1.TabIndex = 2;
            // 
            // mailTaskBindingSource
            // 
            mailTaskBindingSource.DataSource = typeof(MailTask);
            mailTaskBindingSource.CurrentItemChanged += mailTaskBindingSource_CurrentItemChanged;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnStart.Enabled = false;
            btnStart.Location = new Point(6, 14);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(362, 14);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnRun
            // 
            btnRun.Enabled = false;
            btnRun.Location = new Point(724, 14);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 5;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnStart);
            groupBox1.Controls.Add(btnRun);
            groupBox1.Controls.Add(btnStop);
            groupBox1.Location = new Point(12, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(836, 62);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
            taskIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "MailProviderType";
            dataGridViewTextBoxColumn1.HeaderText = "MailProviderType";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ısRunningDataGridViewCheckBoxColumn
            // 
            ısRunningDataGridViewCheckBoxColumn.DataPropertyName = "IsRunning";
            ısRunningDataGridViewCheckBoxColumn.HeaderText = "IsRunning";
            ısRunningDataGridViewCheckBoxColumn.MinimumWidth = 6;
            ısRunningDataGridViewCheckBoxColumn.Name = "ısRunningDataGridViewCheckBoxColumn";
            ısRunningDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ısStartedDataGridViewCheckBoxColumn
            // 
            ısStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            ısStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            ısStartedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            ısStartedDataGridViewCheckBoxColumn.Name = "ısStartedDataGridViewCheckBoxColumn";
            ısStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // secondDataGridViewTextBoxColumn
            // 
            secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
            secondDataGridViewTextBoxColumn.HeaderText = "Second";
            secondDataGridViewTextBoxColumn.MinimumWidth = 6;
            secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            secondDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextRunningDataGridViewTextBoxColumn
            // 
            nextRunningDataGridViewTextBoxColumn.DataPropertyName = "NextRunning";
            nextRunningDataGridViewTextBoxColumn.HeaderText = "NextRunning";
            nextRunningDataGridViewTextBoxColumn.MinimumWidth = 6;
            nextRunningDataGridViewTextBoxColumn.Name = "nextRunningDataGridViewTextBoxColumn";
            nextRunningDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 505);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(lblLogs);
            Controls.Add(btnListMailTasks);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnListMailTasks;
        private ListBox lblLogs;
        private DataGridView dataGridView1;
        private BindingSource mailTaskBindingSource;
        private Button btnStart;
        private Button btnStop;
        private Button btnRun;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn ısRunningDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn ısStartedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nextRunningDataGridViewTextBoxColumn;
    }
}
