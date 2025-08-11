namespace WindowsFormsMediaPlayer
{
    partial class PlayListsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListsForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox_PlayLists = new System.Windows.Forms.ToolStripComboBox();
            this.panel1_MediaRecordControls = new System.Windows.Forms.Panel();
            this.button_DeleteOneRecord = new System.Windows.Forms.Button();
            this.button_AddManyRecord = new System.Windows.Forms.Button();
            this.button_AddOneMediaRecord = new System.Windows.Forms.Button();
            this.listBox_MediaRecords = new System.Windows.Forms.ListBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panel1_MediaRecordControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Info});
            this.statusStrip.Location = new System.Drawing.Point(0, 528);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(391, 26);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Info
            // 
            this.toolStripStatusLabel_Info.Name = "toolStripStatusLabel_Info";
            this.toolStripStatusLabel_Info.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel_Info.Text = "Ready";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playListsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(391, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // playListsToolStripMenuItem
            // 
            this.playListsToolStripMenuItem.Name = "playListsToolStripMenuItem";
            this.playListsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.playListsToolStripMenuItem.Text = "PlayLists";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Add,
            this.toolStripButton_Edit,
            this.toolStripButton_Delete,
            this.toolStripComboBox_PlayLists});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(391, 28);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton_Add
            // 
            this.toolStripButton_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Add.Image = global::WindowsFormsMediaPlayer.Properties.Resources.add1;
            this.toolStripButton_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Add.Name = "toolStripButton_Add";
            this.toolStripButton_Add.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton_Add.Text = "toolStripButton1";
            // 
            // toolStripButton_Edit
            // 
            this.toolStripButton_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Edit.Image = global::WindowsFormsMediaPlayer.Properties.Resources.edit1;
            this.toolStripButton_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Edit.Name = "toolStripButton_Edit";
            this.toolStripButton_Edit.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton_Edit.Text = "toolStripButton2";
            // 
            // toolStripButton_Delete
            // 
            this.toolStripButton_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Delete.Image = global::WindowsFormsMediaPlayer.Properties.Resources.del1;
            this.toolStripButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Delete.Name = "toolStripButton_Delete";
            this.toolStripButton_Delete.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton_Delete.Text = "toolStripButton3";
            // 
            // toolStripComboBox_PlayLists
            // 
            this.toolStripComboBox_PlayLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_PlayLists.Name = "toolStripComboBox_PlayLists";
            this.toolStripComboBox_PlayLists.Size = new System.Drawing.Size(121, 28);
            // 
            // panel1_MediaRecordControls
            // 
            this.panel1_MediaRecordControls.Controls.Add(this.button_DeleteOneRecord);
            this.panel1_MediaRecordControls.Controls.Add(this.button_AddManyRecord);
            this.panel1_MediaRecordControls.Controls.Add(this.button_AddOneMediaRecord);
            this.panel1_MediaRecordControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1_MediaRecordControls.Location = new System.Drawing.Point(269, 56);
            this.panel1_MediaRecordControls.Name = "panel1_MediaRecordControls";
            this.panel1_MediaRecordControls.Size = new System.Drawing.Size(122, 472);
            this.panel1_MediaRecordControls.TabIndex = 3;
            // 
            // button_DeleteOneRecord
            // 
            this.button_DeleteOneRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_DeleteOneRecord.Image = global::WindowsFormsMediaPlayer.Properties.Resources.deleteMedia1;
            this.button_DeleteOneRecord.Location = new System.Drawing.Point(0, 204);
            this.button_DeleteOneRecord.Name = "button_DeleteOneRecord";
            this.button_DeleteOneRecord.Size = new System.Drawing.Size(122, 99);
            this.button_DeleteOneRecord.TabIndex = 2;
            this.button_DeleteOneRecord.UseVisualStyleBackColor = true;
            // 
            // button_AddManyRecord
            // 
            this.button_AddManyRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AddManyRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_AddManyRecord.Image = global::WindowsFormsMediaPlayer.Properties.Resources.addManyMedia1;
            this.button_AddManyRecord.Location = new System.Drawing.Point(0, 103);
            this.button_AddManyRecord.Name = "button_AddManyRecord";
            this.button_AddManyRecord.Size = new System.Drawing.Size(122, 101);
            this.button_AddManyRecord.TabIndex = 1;
            this.button_AddManyRecord.UseVisualStyleBackColor = true;
            // 
            // button_AddOneMediaRecord
            // 
            this.button_AddOneMediaRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AddOneMediaRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_AddOneMediaRecord.Image = global::WindowsFormsMediaPlayer.Properties.Resources.addOneMedia1;
            this.button_AddOneMediaRecord.Location = new System.Drawing.Point(0, 0);
            this.button_AddOneMediaRecord.Name = "button_AddOneMediaRecord";
            this.button_AddOneMediaRecord.Size = new System.Drawing.Size(122, 103);
            this.button_AddOneMediaRecord.TabIndex = 0;
            this.button_AddOneMediaRecord.UseVisualStyleBackColor = true;
            // 
            // listBox_MediaRecords
            // 
            this.listBox_MediaRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_MediaRecords.FormattingEnabled = true;
            this.listBox_MediaRecords.ItemHeight = 16;
            this.listBox_MediaRecords.Location = new System.Drawing.Point(0, 56);
            this.listBox_MediaRecords.Name = "listBox_MediaRecords";
            this.listBox_MediaRecords.Size = new System.Drawing.Size(269, 472);
            this.listBox_MediaRecords.TabIndex = 4;
            // 
            // PlayListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 554);
            this.Controls.Add(this.listBox_MediaRecords);
            this.Controls.Add(this.panel1_MediaRecordControls);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PlayListsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PlayListsForm";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1_MediaRecordControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Info;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton_Add;
        private System.Windows.Forms.ToolStripButton toolStripButton_Edit;
        private System.Windows.Forms.ToolStripButton toolStripButton_Delete;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_PlayLists;
        private System.Windows.Forms.Panel panel1_MediaRecordControls;
        private System.Windows.Forms.Button button_AddOneMediaRecord;
        private System.Windows.Forms.ListBox listBox_MediaRecords;
        private System.Windows.Forms.Button button_DeleteOneRecord;
        private System.Windows.Forms.Button button_AddManyRecord;
    }
}