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
            AppTagPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ViewAllProcesses
            // 
            ViewAllProcesses.FormattingEnabled = true;
            ViewAllProcesses.ItemHeight = 20;
            ViewAllProcesses.Location = new Point(12, 52);
            ViewAllProcesses.Name = "ViewAllProcesses";
            ViewAllProcesses.Size = new Size(233, 164);
            ViewAllProcesses.TabIndex = 0;
            // 
            // Liked
            // 
            Liked.FormattingEnabled = true;
            Liked.ItemHeight = 20;
            Liked.Location = new Point(12, 274);
            Liked.Name = "Liked";
            Liked.Size = new Size(233, 164);
            Liked.TabIndex = 4;
            // 
            // AddToLiked
            // 
            AddToLiked.Location = new Point(12, 222);
            AddToLiked.Name = "AddToLiked";
            AddToLiked.Size = new Size(112, 46);
            AddToLiked.TabIndex = 5;
            AddToLiked.Text = "Add ↓";
            AddToLiked.UseVisualStyleBackColor = true;
            AddToLiked.Click += AddToLiked_Click;
            // 
            // RemoveLiked
            // 
            RemoveLiked.Location = new Point(133, 222);
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
            AppTagPanel.Location = new Point(251, 294);
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
            Tracked.Location = new Point(251, 274);
            Tracked.Name = "Tracked";
            Tracked.Size = new Size(254, 164);
            Tracked.TabIndex = 15;
            // 
            // RefreshProcesses
            // 
            RefreshProcesses.Location = new Point(12, 12);
            RefreshProcesses.Name = "RefreshProcesses";
            RefreshProcesses.Size = new Size(233, 34);
            RefreshProcesses.TabIndex = 8;
            RefreshProcesses.Text = "Refresh";
            RefreshProcesses.UseVisualStyleBackColor = true;
            RefreshProcesses.Click += RefreshProcesses_Click;
            // 
            // StartTracking
            // 
            StartTracking.Location = new Point(251, 12);
            StartTracking.Name = "StartTracking";
            StartTracking.Size = new Size(112, 34);
            StartTracking.TabIndex = 9;
            StartTracking.Text = "Track";
            StartTracking.UseVisualStyleBackColor = true;
            StartTracking.Click += StartTracking_Click;
            // 
            // CheckTime
            // 
            CheckTime.Location = new Point(369, 12);
            CheckTime.Name = "CheckTime";
            CheckTime.Size = new Size(112, 34);
            CheckTime.TabIndex = 13;
            CheckTime.Text = "Check All";
            CheckTime.UseVisualStyleBackColor = true;
            CheckTime.Click += CheckTime_Click;
            // 
            // ShowInfo
            // 
            ShowInfo.Location = new Point(487, 12);
            ShowInfo.Name = "ShowInfo";
            ShowInfo.Size = new Size(112, 34);
            ShowInfo.TabIndex = 14;
            ShowInfo.Text = "Info";
            ShowInfo.UseVisualStyleBackColor = true;
            // 
            // TimeList
            // 
            TimeList.FormattingEnabled = true;
            TimeList.ItemHeight = 20;
            TimeList.Location = new Point(511, 234);
            TimeList.Name = "TimeList";
            TimeList.Size = new Size(277, 164);
            TimeList.TabIndex = 18;
            // 
            // CheckByDate
            // 
            CheckByDate.Location = new Point(511, 201);
            CheckByDate.Name = "CheckByDate";
            CheckByDate.Size = new Size(277, 27);
            CheckByDate.TabIndex = 17;
            CheckByDate.ValueChanged += CheckByDate_ValueChanged;
            // 
            // Label_TrackedProcesses
            // 
            Label_TrackedProcesses.AutoSize = true;
            Label_TrackedProcesses.BackColor = Color.Transparent;
            Label_TrackedProcesses.Location = new Point(251, 248);
            Label_TrackedProcesses.Name = "Label_TrackedProcesses";
            Label_TrackedProcesses.Size = new Size(189, 20);
            Label_TrackedProcesses.TabIndex = 19;
            Label_TrackedProcesses.Text = "Currently tracked processes";
            // 
            // ClearSelectedBttn
            // 
            ClearSelectedBttn.Location = new Point(653, 404);
            ClearSelectedBttn.Name = "ClearSelectedBttn";
            ClearSelectedBttn.Size = new Size(135, 34);
            ClearSelectedBttn.TabIndex = 20;
            ClearSelectedBttn.Text = "Clear Selected";
            ClearSelectedBttn.UseVisualStyleBackColor = true;
            ClearSelectedBttn.Click += ClearSelectedBttn_Click;
            // 
            // ClearAllBttn
            // 
            ClearAllBttn.Location = new Point(511, 404);
            ClearAllBttn.Name = "ClearAllBttn";
            ClearAllBttn.Size = new Size(135, 34);
            ClearAllBttn.TabIndex = 21;
            ClearAllBttn.Text = "Clear All";
            ClearAllBttn.UseVisualStyleBackColor = true;
            ClearAllBttn.Click += ClearAllBttn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Run Time Tracker";
            AppTagPanel.ResumeLayout(false);
            AppTagPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}