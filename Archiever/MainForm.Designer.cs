namespace Archiever
{
    partial class MainForm
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
            this.BUT_OpenFile = new System.Windows.Forms.Button();
            this.LB_SelectedItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BUT_Archive = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BUT_OpenFile
            // 
            this.BUT_OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BUT_OpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUT_OpenFile.Location = new System.Drawing.Point(15, 295);
            this.BUT_OpenFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BUT_OpenFile.Name = "BUT_OpenFile";
            this.BUT_OpenFile.Size = new System.Drawing.Size(331, 35);
            this.BUT_OpenFile.TabIndex = 0;
            this.BUT_OpenFile.Text = "Select";
            this.BUT_OpenFile.UseVisualStyleBackColor = true;
            this.BUT_OpenFile.Click += new System.EventHandler(this.BUT_OpenFile_Click);
            // 
            // LB_SelectedItems
            // 
            this.LB_SelectedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_SelectedItems.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SelectedItems.FormattingEnabled = true;
            this.LB_SelectedItems.HorizontalScrollbar = true;
            this.LB_SelectedItems.ItemHeight = 19;
            this.LB_SelectedItems.Location = new System.Drawing.Point(15, 11);
            this.LB_SelectedItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LB_SelectedItems.Name = "LB_SelectedItems";
            this.LB_SelectedItems.Size = new System.Drawing.Size(666, 232);
            this.LB_SelectedItems.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select files to compress:";
            // 
            // BUT_Archive
            // 
            this.BUT_Archive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Archive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUT_Archive.Location = new System.Drawing.Point(350, 295);
            this.BUT_Archive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BUT_Archive.Name = "BUT_Archive";
            this.BUT_Archive.Size = new System.Drawing.Size(331, 35);
            this.BUT_Archive.TabIndex = 3;
            this.BUT_Archive.Text = "Archive";
            this.BUT_Archive.UseVisualStyleBackColor = true;
            this.BUT_Archive.Click += new System.EventHandler(this.BUT_Archive_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Archieve selected items:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BUT_Archive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_SelectedItems);
            this.Controls.Add(this.BUT_OpenFile);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(713, 387);
            this.Name = "MainForm";
            this.Text = "Archiever";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUT_OpenFile;
        private System.Windows.Forms.ListBox LB_SelectedItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BUT_Archive;
        private System.Windows.Forms.Label label2;
    }
}

