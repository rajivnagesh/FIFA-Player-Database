namespace FIFA_MANAGEMENT_SYSTEM
{
    partial class Setting_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_UserControl));
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // SettingsInfoLabel
            // 
            this.SettingsInfoLabel.AutoSize = true;
            this.SettingsInfoLabel.Location = new System.Drawing.Point(48, 70);
            this.SettingsInfoLabel.Name = "SettingsInfoLabel";
            this.SettingsInfoLabel.Size = new System.Drawing.Size(360, 391);
            this.SettingsInfoLabel.TabIndex = 1;
            this.SettingsInfoLabel.Text = resources.GetString("SettingsInfoLabel.Text");
            // 
            // Setting_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.SettingsInfoLabel);
            this.Controls.Add(this.label1);
            this.Name = "Setting_UserControl";
            this.Size = new System.Drawing.Size(502, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SettingsInfoLabel;
    }
}
