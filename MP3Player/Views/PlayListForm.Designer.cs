namespace MP3Player.Views
{
    partial class PlayListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListForm));
            this.treeView = new System.Windows.Forms.TreeView();
            this.createPLButton = new System.Windows.Forms.Button();
            this.renamePLButton = new System.Windows.Forms.Button();
            this.deletePLButton = new System.Windows.Forms.Button();
            this.addFileButton = new System.Windows.Forms.Button();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.playSelectedButton = new System.Windows.Forms.Button();
            this.repeatButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(95, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(311, 237);
            this.treeView.TabIndex = 7;
            this.treeView.TabStop = false;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // createPLButton
            // 
            this.createPLButton.Location = new System.Drawing.Point(12, 98);
            this.createPLButton.Name = "createPLButton";
            this.createPLButton.Size = new System.Drawing.Size(77, 23);
            this.createPLButton.TabIndex = 2;
            this.createPLButton.Text = "Create PL";
            this.toolTip.SetToolTip(this.createPLButton, "Create playlist");
            this.createPLButton.UseVisualStyleBackColor = true;
            this.createPLButton.Click += new System.EventHandler(this.createPLButton_Click);
            // 
            // renamePLButton
            // 
            this.renamePLButton.Enabled = false;
            this.renamePLButton.Location = new System.Drawing.Point(12, 127);
            this.renamePLButton.Name = "renamePLButton";
            this.renamePLButton.Size = new System.Drawing.Size(77, 23);
            this.renamePLButton.TabIndex = 3;
            this.renamePLButton.Text = "Rename PL";
            this.toolTip.SetToolTip(this.renamePLButton, "Rename selected playlist");
            this.renamePLButton.UseVisualStyleBackColor = true;
            this.renamePLButton.Click += new System.EventHandler(this.renamePLButton_Click);
            // 
            // deletePLButton
            // 
            this.deletePLButton.Enabled = false;
            this.deletePLButton.Location = new System.Drawing.Point(12, 156);
            this.deletePLButton.Name = "deletePLButton";
            this.deletePLButton.Size = new System.Drawing.Size(77, 23);
            this.deletePLButton.TabIndex = 4;
            this.deletePLButton.Text = "Delete PL";
            this.toolTip.SetToolTip(this.deletePLButton, "Delete selected playlist");
            this.deletePLButton.UseVisualStyleBackColor = true;
            this.deletePLButton.Click += new System.EventHandler(this.deletePLButton_Click);
            // 
            // addFileButton
            // 
            this.addFileButton.Enabled = false;
            this.addFileButton.Location = new System.Drawing.Point(12, 226);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(77, 23);
            this.addFileButton.TabIndex = 6;
            this.addFileButton.Text = "Add file";
            this.toolTip.SetToolTip(this.addFileButton, "Add file to selected playlist");
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // deleteFileButton
            // 
            this.deleteFileButton.Enabled = false;
            this.deleteFileButton.Location = new System.Drawing.Point(12, 197);
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.Size = new System.Drawing.Size(77, 23);
            this.deleteFileButton.TabIndex = 5;
            this.deleteFileButton.Text = "Delete file";
            this.toolTip.SetToolTip(this.deleteFileButton, "Delete selected file");
            this.deleteFileButton.UseVisualStyleBackColor = true;
            this.deleteFileButton.Click += new System.EventHandler(this.deleteFileButton_Click);
            // 
            // playSelectedButton
            // 
            this.playSelectedButton.Enabled = false;
            this.playSelectedButton.Location = new System.Drawing.Point(12, 12);
            this.playSelectedButton.Name = "playSelectedButton";
            this.playSelectedButton.Size = new System.Drawing.Size(35, 23);
            this.playSelectedButton.TabIndex = 0;
            this.playSelectedButton.Text = "▶";
            this.toolTip.SetToolTip(this.playSelectedButton, "Play selected item");
            this.playSelectedButton.UseVisualStyleBackColor = true;
            this.playSelectedButton.Click += new System.EventHandler(this.playSelectedButton_Click);
            // 
            // repeatButton
            // 
            this.repeatButton.Location = new System.Drawing.Point(53, 12);
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(36, 23);
            this.repeatButton.TabIndex = 1;
            this.repeatButton.Text = "🔁";
            this.toolTip.SetToolTip(this.repeatButton, "Repeat selected item");
            this.repeatButton.UseVisualStyleBackColor = true;
            this.repeatButton.Click += new System.EventHandler(this.repeatButton_Click);
            // 
            // PlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(418, 261);
            this.Controls.Add(this.repeatButton);
            this.Controls.Add(this.playSelectedButton);
            this.Controls.Add(this.deleteFileButton);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.deletePLButton);
            this.Controls.Add(this.renamePLButton);
            this.Controls.Add(this.createPLButton);
            this.Controls.Add(this.treeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayListForm";
            this.ShowInTaskbar = false;
            this.Text = "PlayLists";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayListForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createPLButton;
        private System.Windows.Forms.Button renamePLButton;
        private System.Windows.Forms.Button deletePLButton;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Button deleteFileButton;
        private System.Windows.Forms.Button playSelectedButton;
        private System.Windows.Forms.Button repeatButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TreeView treeView;
    }
}