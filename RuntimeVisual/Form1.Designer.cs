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
            SuspendLayout();
            // 
            // ViewAllProcesses
            // 
            ViewAllProcesses.FormattingEnabled = true;
            ViewAllProcesses.ItemHeight = 20;
            ViewAllProcesses.Location = new Point(12, 12);
            ViewAllProcesses.Name = "ViewAllProcesses";
            ViewAllProcesses.Size = new Size(233, 204);
            ViewAllProcesses.TabIndex = 0;
            ViewAllProcesses.SelectedIndexChanged += ViewProcesses_SelectedIndexChanged;
            // 
            // test
            // 
            test.AutoSize = true;
            test.Location = new Point(582, 132);
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
            AddToLiked.Size = new Size(115, 46);
            AddToLiked.TabIndex = 5;
            AddToLiked.Text = "Add ↓";
            AddToLiked.UseVisualStyleBackColor = true;
            AddToLiked.Click += AddToLiked_Click;
            // 
            // RemoveLiked
            // 
            RemoveLiked.Location = new Point(133, 222);
            RemoveLiked.Name = "RemoveLiked";
            RemoveLiked.Size = new Size(115, 46);
            RemoveLiked.TabIndex = 6;
            RemoveLiked.Text = "Remove ↑";
            RemoveLiked.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveLiked);
            Controls.Add(AddToLiked);
            Controls.Add(Liked);
            Controls.Add(test);
            Controls.Add(ViewAllProcesses);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ViewAllProcesses;
        private Label test;
        private ListBox Liked;
        private Button AddToLiked;
        private Button RemoveLiked;
    }
}