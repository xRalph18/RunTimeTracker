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
            test = new Label();
            Liked = new ListBox();
            AddToLiked = new Button();
            RemoveLiked = new Button();
            AppTagPanel = new Panel();
            CancleTag = new Button();
            SubmitTag = new Button();
            TagLabel = new Label();
            AppTag = new TextBox();
            RefreshProcesses = new Button();
            StartTracking = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
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
            ViewAllProcesses.SelectedIndexChanged += ViewProcesses_SelectedIndexChanged;
            // 
            // test
            // 
            test.AutoSize = true;
            test.Location = new Point(266, 92);
            test.Name = "test";
            test.Size = new Size(50, 20);
            test.TabIndex = 2;
            test.Text = "label1";
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
            AppTagPanel.BackColor = Color.Gainsboro;
            AppTagPanel.Controls.Add(CancleTag);
            AppTagPanel.Controls.Add(SubmitTag);
            AppTagPanel.Controls.Add(TagLabel);
            AppTagPanel.Controls.Add(AppTag);
            AppTagPanel.Location = new Point(251, 294);
            AppTagPanel.Name = "AppTagPanel";
            AppTagPanel.Size = new Size(262, 126);
            AppTagPanel.TabIndex = 7;
            AppTagPanel.Visible = false;
            // 
            // CancleTag
            // 
            CancleTag.Location = new Point(51, 83);
            CancleTag.Name = "CancleTag";
            CancleTag.Size = new Size(94, 29);
            CancleTag.TabIndex = 3;
            CancleTag.Text = "Cancle";
            CancleTag.UseVisualStyleBackColor = true;
            CancleTag.Click += CancleTag_Click;
            // 
            // SubmitTag
            // 
            SubmitTag.Location = new Point(151, 83);
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
            AppTag.Size = new Size(230, 27);
            AppTag.TabIndex = 0;
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
            // panel1
            // 
            panel1.Location = new Point(587, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 210);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Location = new Point(587, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 210);
            panel2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(StartTracking);
            Controls.Add(RefreshProcesses);
            Controls.Add(AppTagPanel);
            Controls.Add(RemoveLiked);
            Controls.Add(AddToLiked);
            Controls.Add(Liked);
            Controls.Add(test);
            Controls.Add(ViewAllProcesses);
            Name = "Form1";
            Text = "Form1";
            AppTagPanel.ResumeLayout(false);
            AppTagPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ViewAllProcesses;
        private Label test;
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
        private Panel panel1;
        private Panel panel2;
    }
}