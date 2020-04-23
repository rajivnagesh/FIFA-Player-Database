namespace FIFA_MANAGEMENT_SYSTEM
{
    partial class Country_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Country_UserControl));
            this.Country = new System.Windows.Forms.Label();
            this.CountryInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.BackColor = System.Drawing.Color.Aqua;
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.Location = new System.Drawing.Point(175, 37);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(143, 39);
            this.Country.TabIndex = 0;
            this.Country.Text = "Country";
            // 
            // CountryInfoLabel
            // 
            this.CountryInfoLabel.AutoSize = true;
            this.CountryInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryInfoLabel.Location = new System.Drawing.Point(55, 140);
            this.CountryInfoLabel.Name = "CountryInfoLabel";
            this.CountryInfoLabel.Size = new System.Drawing.Size(355, 216);
            this.CountryInfoLabel.TabIndex = 1;
            this.CountryInfoLabel.Text = resources.GetString("CountryInfoLabel.Text");
            // 
            // Country_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.CountryInfoLabel);
            this.Controls.Add(this.Country);
            this.Name = "Country_UserControl";
            this.Size = new System.Drawing.Size(502, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label CountryInfoLabel;
    }
}
