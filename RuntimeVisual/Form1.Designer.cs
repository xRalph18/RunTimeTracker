namespace RuntimeVisual
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ViewAllProcesses = new ListBox();
            Liked = new ListBox();
            AddToLiked = new Button();
            RemoveLiked = new Button();
            AppTagPanel = new Panel();
            CancleTag = new Button();
            SubmitTag = new Button();
            TagLabel = new Label();
            AppTag = new TextBox();
            Tracked = new ListBox();
            RefreshProcesses = new Button();
            StartTracking = new Button();
            CheckTime = new Button();
            ShowInfo = new Button();
            TimeList = new ListBox();
            CheckByDate = new DateTimePicker();
            Label_TrackedProcesses = new Label();
            ClearSelectedBttn = new Button();
            ClearAllBttn = new Button();
            ImportTime = new Button();
            ImportLiked = new Button();
            File_Time = new OpenFileDialog();
            File_Liked = new OpenFileDialog();
            Save_Time = new SaveFileDialog();
            SaveLiked = new Button();
            SaveTime = new Button();
            Save_Liked = new SaveFileDialog();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            Apps = new Label();
            FileSize = new Label();
            Compress = new Button();
            AppTagPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ViewAllProcesses
            // 
            ViewAllProcesses.FormattingEnabled = true;
            ViewAllProcesses.ItemHeight = 20;
            ViewAllProcesses.Location = new Point(12, 53);
            ViewAllProcesses.Name = "ViewAllProcesses";
            ViewAllProcesses.Size = new Size(233, 164);
            ViewAllProcesses.TabIndex = 0;
            // 
            // Liked
            // 
            Liked.FormattingEnabled = true;
            Liked.ItemHeight = 20;
            Liked.Location = new Point(12, 275);
            Liked.Name = "Liked";
            Liked.Size = new Size(233, 164);
            Liked.TabIndex = 4;
            // 
            // AddToLiked
            // 
            AddToLiked.Location = new Point(12, 223);
            AddToLiked.Name = "AddToLiked";
            AddToLiked.Size = new Size(112, 46);
            AddToLiked.TabIndex = 5;
            AddToLiked.Text = "Add ↓";
            AddToLiked.UseVisualStyleBackColor = true;
            AddToLiked.Click += AddToLiked_Click;
            // 
            // RemoveLiked
            // 
            RemoveLiked.Location = new Point(133, 223);
            RemoveLiked.Name = "RemoveLiked";
            RemoveLiked.Size = new Size(112, 46);
            RemoveLiked.TabIndex = 6;
            RemoveLiked.Text = "Remove ↑";
            RemoveLiked.UseVisualStyleBackColor = true;
            RemoveLiked.Click += RemoveLiked_Click;
            // 
            // AppTagPanel
            // 
            AppTagPanel.BackColor = SystemColors.Control;
            AppTagPanel.BorderStyle = BorderStyle.FixedSingle;
            AppTagPanel.Controls.Add(CancleTag);
            AppTagPanel.Controls.Add(SubmitTag);
            AppTagPanel.Controls.Add(TagLabel);
            AppTagPanel.Controls.Add(AppTag);
            AppTagPanel.Location = new Point(251, 295);
            AppTagPanel.Name = "AppTagPanel";
            AppTagPanel.Size = new Size(254, 126);
            AppTagPanel.TabIndex = 7;
            AppTagPanel.Visible = false;
            // 
            // CancleTag
            // 
            CancleTag.Location = new Point(45, 83);
            CancleTag.Name = "CancleTag";
            CancleTag.Size = new Size(94, 29);
            CancleTag.TabIndex = 3;
            CancleTag.Text = "Cancle";
            CancleTag.UseVisualStyleBackColor = true;
            CancleTag.Click += CancleTag_Click;
            // 
            // SubmitTag
            // 
            SubmitTag.Location = new Point(145, 83);
            SubmitTag.Name = "SubmitTag";
            SubmitTag.Size = new Size(94, 29);
            SubmitTag.TabIndex = 2;
            SubmitTag.Text = "Submit";
            SubmitTag.UseVisualStyleBackColor = true;
            SubmitTag.Click += SubmitTag_Click;
            // 
            // TagLabel
            // 
            TagLabel.AutoSize = true;
            TagLabel.BackColor = Color.Transparent;
            TagLabel.Location = new Point(15, 17);
            TagLabel.Name = "TagLabel";
            TagLabel.Size = new Size(158, 20);
            TagLabel.TabIndex = 1;
            TagLabel.Text = "Set tag for application";
            // 
            // AppTag
            // 
            AppTag.Location = new Point(15, 50);
            AppTag.Name = "AppTag";
            AppTag.PlaceholderText = "Type app tag";
            AppTag.Size = new Size(224, 27);
            AppTag.TabIndex = 0;
            // 
            // Tracked
            // 
            Tracked.FormattingEnabled = true;
            Tracked.ItemHeight = 20;
            Tracked.Location = new Point(251, 275);
            Tracked.Name = "Tracked";
            Tracked.Size = new Size(254, 164);
            Tracked.TabIndex = 15;
            // 
            // RefreshProcesses
            // 
            RefreshProcesses.Location = new Point(12, 13);
            RefreshProcesses.Name = "RefreshProcesses";
            RefreshProcesses.Size = new Size(233, 34);
            RefreshProcesses.TabIndex = 8;
            RefreshProcesses.Text = "Refresh";
            RefreshProcesses.UseVisualStyleBackColor = true;
            RefreshProcesses.Click += RefreshProcesses_Click;
            // 
            // StartTracking
            // 
            StartTracking.Location = new Point(251, 13);
            StartTracking.Name = "StartTracking";
            StartTracking.Size = new Size(112, 34);
            StartTracking.TabIndex = 9;
            StartTracking.Text = "Track";
            StartTracking.UseVisualStyleBackColor = true;
            StartTracking.Click += StartTracking_Click;
            // 
            // CheckTime
            // 
            CheckTime.Location = new Point(369, 13);
            CheckTime.Name = "CheckTime";
            CheckTime.Size = new Size(112, 34);
            CheckTime.TabIndex = 13;
            CheckTime.Text = "Check All";
            CheckTime.UseVisualStyleBackColor = true;
            CheckTime.Click += CheckTime_Click;
            // 
            // ShowInfo
            // 
            ShowInfo.Location = new Point(487, 13);
            ShowInfo.Name = "ShowInfo";
            ShowInfo.Size = new Size(112, 34);
            ShowInfo.TabIndex = 14;
            ShowInfo.Text = "Info";
            ShowInfo.UseVisualStyleBackColor = true;
            ShowInfo.Click += ShowInfo_Click;
            // 
            // TimeList
            // 
            TimeList.FormattingEnabled = true;
            TimeList.ItemHeight = 20;
            TimeList.Location = new Point(511, 235);
            TimeList.Name = "TimeList";
            TimeList.Size = new Size(277, 164);
            TimeList.TabIndex = 18;
            // 
            // CheckByDate
            // 
            CheckByDate.Location = new Point(511, 202);
            CheckByDate.Name = "CheckByDate";
            CheckByDate.Size = new Size(277, 27);
            CheckByDate.TabIndex = 17;
            CheckByDate.ValueChanged += CheckByDate_ValueChanged;
            // 
            // Label_TrackedProcesses
            // 
            Label_TrackedProcesses.BackColor = Color.Transparent;
            Label_TrackedProcesses.Location = new Point(251, 249);
            Label_TrackedProcesses.Name = "Label_TrackedProcesses";
            Label_TrackedProcesses.Size = new Size(254, 20);
            Label_TrackedProcesses.TabIndex = 19;
            Label_TrackedProcesses.Text = "Currently tracked processes";
            Label_TrackedProcesses.TextAlign = ContentAlignment.BottomCenter;
            // 
            // ClearSelectedBttn
            // 
            ClearSelectedBttn.Location = new Point(653, 405);
            ClearSelectedBttn.Name = "ClearSelectedBttn";
            ClearSelectedBttn.Size = new Size(135, 34);
            ClearSelectedBttn.TabIndex = 20;
            ClearSelectedBttn.Text = "Clear Selected";
            ClearSelectedBttn.UseVisualStyleBackColor = true;
            ClearSelectedBttn.Click += ClearSelectedBttn_Click;
            // 
            // ClearAllBttn
            // 
            ClearAllBttn.Location = new Point(511, 405);
            ClearAllBttn.Name = "ClearAllBttn";
            ClearAllBttn.Size = new Size(135, 34);
            ClearAllBttn.TabIndex = 21;
            ClearAllBttn.Text = "Clear All";
            ClearAllBttn.UseVisualStyleBackColor = true;
            ClearAllBttn.Click += ClearAllBttn_Click;
            // 
            // ImportTime
            // 
            ImportTime.BackgroundImageLayout = ImageLayout.None;
            ImportTime.ImageAlign = ContentAlignment.MiddleLeft;
            ImportTime.Location = new Point(369, 53);
            ImportTime.Name = "ImportTime";
            ImportTime.Size = new Size(112, 34);
            ImportTime.TabIndex = 22;
            ImportTime.Text = "Import Time";
            ImportTime.UseVisualStyleBackColor = true;
            ImportTime.Click += ImportTime_Click;
            // 
            // ImportLiked
            // 
            ImportLiked.BackgroundImageLayout = ImageLayout.None;
            ImportLiked.ImageAlign = ContentAlignment.MiddleLeft;
            ImportLiked.Location = new Point(251, 53);
            ImportLiked.Name = "ImportLiked";
            ImportLiked.Size = new Size(112, 34);
            ImportLiked.TabIndex = 23;
            ImportLiked.Text = "Import Liked";
            ImportLiked.UseVisualStyleBackColor = true;
            ImportLiked.Click += ImportLiked_Click;
            // 
            // File_Time
            // 
            File_Time.FileName = "TimeData.json";
            // 
            // File_Liked
            // 
            File_Liked.FileName = "Liked.json";
            // 
            // Save_Time
            // 
            Save_Time.FileName = "TimeData.json";
            Save_Time.InitialDirectory = "Desktop";
            // 
            // SaveLiked
            // 
            SaveLiked.BackgroundImageLayout = ImageLayout.None;
            SaveLiked.ImageAlign = ContentAlignment.MiddleLeft;
            SaveLiked.Location = new Point(251, 93);
            SaveLiked.Name = "SaveLiked";
            SaveLiked.Size = new Size(112, 34);
            SaveLiked.TabIndex = 24;
            SaveLiked.Text = "Save Liked";
            SaveLiked.UseVisualStyleBackColor = true;
            SaveLiked.Click += SaveLiked_Click;
            // 
            // SaveTime
            // 
            SaveTime.BackgroundImageLayout = ImageLayout.None;
            SaveTime.ImageAlign = ContentAlignment.MiddleLeft;
            SaveTime.Location = new Point(369, 93);
            SaveTime.Name = "SaveTime";
            SaveTime.Size = new Size(112, 34);
            SaveTime.TabIndex = 25;
            SaveTime.Text = "Save Time";
            SaveTime.UseVisualStyleBackColor = true;
            SaveTime.Click += SaveTime_Click;
            // 
            // Save_Liked
            // 
            Save_Liked.FileName = "Liked.json";
            Save_Liked.InitialDirectory = "Desktop";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Apps);
            panel1.Controls.Add(FileSize);
            panel1.Location = new Point(605, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 183);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 35);
            panel2.TabIndex = 28;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 34);
            label1.TabIndex = 27;
            label1.Text = "Statistics";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Apps
            // 
            Apps.Location = new Point(0, 36);
            Apps.Name = "Apps";
            Apps.Size = new Size(182, 20);
            Apps.TabIndex = 1;
            Apps.Text = "Apps:";
            // 
            // FileSize
            // 
            FileSize.Location = new Point(0, 56);
            FileSize.Name = "FileSize";
            FileSize.Size = new Size(182, 20);
            FileSize.TabIndex = 0;
            FileSize.Text = "Size:";
            // 
            // Compress
            // 
            Compress.Location = new Point(487, 53);
            Compress.Name = "Compress";
            Compress.Size = new Size(112, 34);
            Compress.TabIndex = 27;
            Compress.Text = "Compress";
            Compress.UseVisualStyleBackColor = true;
            Compress.Click += Compress_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(Compress);
            Controls.Add(panel1);
            Controls.Add(SaveTime);
            Controls.Add(SaveLiked);
            Controls.Add(ImportLiked);
            Controls.Add(ImportTime);
            Controls.Add(Label_TrackedProcesses);
            Controls.Add(ClearAllBttn);
            Controls.Add(ClearSelectedBttn);
            Controls.Add(AppTagPanel);
            Controls.Add(TimeList);
            Controls.Add(CheckByDate);
            Controls.Add(Tracked);
            Controls.Add(ShowInfo);
            Controls.Add(CheckTime);
            Controls.Add(StartTracking);
            Controls.Add(RefreshProcesses);
            Controls.Add(RemoveLiked);
            Controls.Add(AddToLiked);
            Controls.Add(Liked);
            Controls.Add(ViewAllProcesses);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Run Time Tracker";
            AppTagPanel.ResumeLayout(false);
            AppTagPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox ViewAllProcesses;
        private ListBox Liked;
        private Button AddToLiked;
        private Button RemoveLiked;
        private Panel AppTagPanel;
        private Button SubmitTag;
        private Label TagLabel;
        private TextBox AppTag;
        private Button CancleTag;
        private Button RefreshProcesses;
        private Button StartTracking;
        private Button CheckTime;
        private Button ShowInfo;
        private ListBox Tracked;
        private ListBox TimeList;
        private DateTimePicker CheckByDate;
        private Label Label_TrackedProcesses;
        private Button ClearSelectedBttn;
        private Button ClearAllBttn;
        private Button ImportTime;
        private Button ImportLiked;
        private OpenFileDialog File_Time;
        private OpenFileDialog File_Liked;
        private SaveFileDialog Save_Time;
        private Button SaveLiked;
        private Button SaveTime;
        private SaveFileDialog Save_Liked;
        private Panel panel1;
        private Label label1;
        private Label Apps;
        private Label FileSize;
        private Panel panel2;
        private Button Compress;
    }
}