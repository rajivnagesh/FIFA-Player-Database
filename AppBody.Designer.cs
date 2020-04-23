namespace FIFA_MANAGEMENT_SYSTEM
{
    partial class AppBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            this.Log_in_Timer = new System.Windows.Forms.Timer(this.components);
            this.TilteBarPanel = new System.Windows.Forms.Panel();
            this.SlidingPanel_Timer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.AboutTabButton = new System.Windows.Forms.Button();
            this.SettingsTabButton = new System.Windows.Forms.Button();
            this.CountryTabButton = new System.Windows.Forms.Button();
            this.TeamTabButton = new System.Windows.Forms.Button();
            this.PlayerTabButton = new System.Windows.Forms.Button();
            this.SlidingPanel_ToggleButton = new System.Windows.Forms.Button();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TilteBarPanel.SuspendLayout();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_in_Timer
            // 
            this.Log_in_Timer.Interval = 25;
            this.Log_in_Timer.Tick += new System.EventHandler(this.Log_in_Timer_Tick);
            // 
            // TilteBarPanel
            // 
            this.TilteBarPanel.BackColor = System.Drawing.Color.Blue;
            this.TilteBarPanel.Controls.Add(this.LogOffButton);
            this.TilteBarPanel.Controls.Add(this.MinimizeButton);
            this.TilteBarPanel.Controls.Add(this.CloseButton);
            this.TilteBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TilteBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TilteBarPanel.Name = "TilteBarPanel";
            this.TilteBarPanel.Size = new System.Drawing.Size(801, 36);
            this.TilteBarPanel.TabIndex = 0;
            this.TilteBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // SlidingPanel_Timer
            // 
            this.SlidingPanel_Timer.Interval = 50;
            this.SlidingPanel_Timer.Tick += new System.EventHandler(this.SlidingPanel_Timer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(299, 36);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(502, 476);
            this.ContentPanel.TabIndex = 2;
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.Color.Aqua;
            this.SlidingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlidingPanel.BackgroundImage")));
            this.SlidingPanel.Controls.Add(this.AboutTabButton);
            this.SlidingPanel.Controls.Add(this.SettingsTabButton);
            this.SlidingPanel.Controls.Add(this.CountryTabButton);
            this.SlidingPanel.Controls.Add(this.TeamTabButton);
            this.SlidingPanel.Controls.Add(this.PlayerTabButton);
            this.SlidingPanel.Controls.Add(this.SlidingPanel_ToggleButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 36);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(300, 476);
            this.SlidingPanel.TabIndex = 1;
            // 
            // AboutTabButton
            // 
            this.AboutTabButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTabButton.Image = global::FIFA_MANAGEMENT_SYSTEM.Properties.Resources.info;
            this.AboutTabButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AboutTabButton.Location = new System.Drawing.Point(0, 265);
            this.AboutTabButton.Name = "AboutTabButton";
            this.AboutTabButton.Size = new System.Drawing.Size(300, 47);
            this.AboutTabButton.TabIndex = 7;
            this.AboutTabButton.Text = "ABOUT";
            this.AboutTabButton.UseVisualStyleBackColor = false;
            this.AboutTabButton.Click += new System.EventHandler(this.AboutTabButton_Click);
            // 
            // SettingsTabButton
            // 
            this.SettingsTabButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTabButton.Image = global::FIFA_MANAGEMENT_SYSTEM.Properties.Resources.gear;
            this.SettingsTabButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SettingsTabButton.Location = new System.Drawing.Point(0, 212);
            this.SettingsTabButton.Name = "SettingsTabButton";
            this.SettingsTabButton.Size = new System.Drawing.Size(300, 47);
            this.SettingsTabButton.TabIndex = 6;
            this.SettingsTabButton.Text = "SETTINGS";
            this.SettingsTabButton.UseVisualStyleBackColor = false;
            this.SettingsTabButton.Click += new System.EventHandler(this.SettingsTabButton_Click);
            // 
            // CountryTabButton
            // 
            this.CountryTabButton.BackColor = System.Drawing.Color.Transparent;
            this.CountryTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountryTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryTabButton.Image = global::FIFA_MANAGEMENT_SYSTEM.Properties.Resources.flag;
            this.CountryTabButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CountryTabButton.Location = new System.Drawing.Point(0, 159);
            this.CountryTabButton.Name = "CountryTabButton";
            this.CountryTabButton.Size = new System.Drawing.Size(300, 47);
            this.CountryTabButton.TabIndex = 5;
            this.CountryTabButton.Text = "COUNTRY";
            this.CountryTabButton.UseVisualStyleBackColor = false;
            this.CountryTabButton.Click += new System.EventHandler(this.CountryTabButton_Click);
            // 
            // TeamTabButton
            // 
            this.TeamTabButton.BackColor = System.Drawing.Color.Transparent;
            this.TeamTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTabButton.Image = global::FIFA_MANAGEMENT_SYSTEM.Properties.Resources.team;
            this.TeamTabButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TeamTabButton.Location = new System.Drawing.Point(0, 106);
            this.TeamTabButton.Name = "TeamTabButton";
            this.TeamTabButton.Size = new System.Drawing.Size(300, 47);
            this.TeamTabButton.TabIndex = 4;
            this.TeamTabButton.Text = "TEAM";
            this.TeamTabButton.UseVisualStyleBackColor = false;
            this.TeamTabButton.Click += new System.EventHandler(this.TeamTabButton_Click);
            // 
            // PlayerTabButton
            // 
            this.PlayerTabButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTabButton.Image = global::FIFA_MANAGEMENT_SYSTEM.Properties.Resources.players;
            this.PlayerTabButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PlayerTabButton.Location = new System.Drawing.Point(0, 53);
            this.PlayerTabButton.Name = "PlayerTabButton";
            this.PlayerTabButton.Size = new System.Drawing.Size(300, 47);
            this.PlayerTabButton.TabIndex = 3;
            this.PlayerTabButton.Text = "PLAYER";
            this.PlayerTabButton.UseVisualStyleBackColor = false;
            this.PlayerTabButton.Click += new System.EventHandler(this.PlayerTabButton_Click);
            // 
            // SlidingPanel_ToggleButton
            // 
            this.SlidingPanel_ToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.SlidingPanel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPanel_ToggleButton.Image = global::FIFA_MANAGEMENT_SYSTEM.Properties.Resources.left;
            this.SlidingPanel_ToggleButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SlidingPanel_ToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel_ToggleButton.Name = "SlidingPanel_ToggleButton";
            this.SlidingPanel_ToggleButton.Size = new System.Drawing.Size(300, 47);
            this.SlidingPanel_ToggleButton.TabIndex = 2;
            this.SlidingPanel_ToggleButton.UseVisualStyleBackColor = false;
            this.SlidingPanel_ToggleButton.Click += new System.EventHandler(this.SlidingPanel_ToggleButton_Click);
            // 
            // LogOffButton
            // 
            this.LogOffButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOffButton.BackgroundImage")));
            this.LogOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOffButton.ForeColor = System.Drawing.Color.Aqua;
            this.LogOffButton.Location = new System.Drawing.Point(683, 0);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(34, 33);
            this.LogOffButton.TabIndex = 2;
            this.LogOffButton.UseVisualStyleBackColor = true;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.Aqua;
            this.MinimizeButton.Location = new System.Drawing.Point(723, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(34, 33);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.Aqua;
            this.CloseButton.Location = new System.Drawing.Point(763, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 34);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 512);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SlidingPanel);
            this.Controls.Add(this.TilteBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.TilteBarPanel.ResumeLayout(false);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_in_Timer;
        private System.Windows.Forms.Panel TilteBarPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidingPanel_ToggleButton;
        private System.Windows.Forms.Timer SlidingPanel_Timer;
        private System.Windows.Forms.Button AboutTabButton;
        private System.Windows.Forms.Button SettingsTabButton;
        private System.Windows.Forms.Button CountryTabButton;
        private System.Windows.Forms.Button TeamTabButton;
        private System.Windows.Forms.Button PlayerTabButton;
        private System.Windows.Forms.Panel ContentPanel;
    }
}