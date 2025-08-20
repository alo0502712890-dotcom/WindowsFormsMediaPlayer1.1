namespace WindowsFormsMediaPlayer
{
    partial class CreateUodatePlayListForm
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
            this.label = new System.Windows.Forms.Label();
            this.textBox_PlayListName = new System.Windows.Forms.TextBox();
            this.button_Censel = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(4, 4);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 18);
            this.label.TabIndex = 0;
            this.label.Text = "PlayList Name";
            // 
            // textBox_PlayListName
            // 
            this.textBox_PlayListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PlayListName.Location = new System.Drawing.Point(7, 45);
            this.textBox_PlayListName.Name = "textBox_PlayListName";
            this.textBox_PlayListName.Size = new System.Drawing.Size(283, 28);
            this.textBox_PlayListName.TabIndex = 1;
            // 
            // button_Censel
            // 
            this.button_Censel.BackColor = System.Drawing.Color.IndianRed;
            this.button_Censel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Censel.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Censel.Location = new System.Drawing.Point(7, 103);
            this.button_Censel.Name = "button_Censel";
            this.button_Censel.Size = new System.Drawing.Size(119, 44);
            this.button_Censel.TabIndex = 2;
            this.button_Censel.Text = "Cancel";
            this.button_Censel.UseVisualStyleBackColor = false;
            this.button_Censel.Click += new System.EventHandler(this.button_Censel_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.BackColor = System.Drawing.Color.YellowGreen;
            this.button_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Confirm.Location = new System.Drawing.Point(163, 103);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(114, 44);
            this.button_Confirm.TabIndex = 3;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = false;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 180);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(302, 26);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 20);
            this.toolStripStatusLabel1.Text = "Ready...";
            // 
            // CreateUodatePlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 206);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.button_Censel);
            this.Controls.Add(this.textBox_PlayListName);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CreateUodatePlayListForm";
            this.Text = "CreateUodatePlayListForm";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox_PlayListName;
        private System.Windows.Forms.Button button_Censel;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}