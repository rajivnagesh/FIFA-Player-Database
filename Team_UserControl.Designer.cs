namespace FIFA_MANAGEMENT_SYSTEM
{
    partial class Team_UserControl
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
            this.TeamID = new System.Windows.Forms.Label();
            this.TeamIDtextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.CountryIDLabel = new System.Windows.Forms.Label();
            this.CountryIDtextBox = new System.Windows.Forms.TextBox();
            this.TeamNamelabel = new System.Windows.Forms.Label();
            this.StadiumNamelabel = new System.Windows.Forms.Label();
            this.TeamNametextBox = new System.Windows.Forms.TextBox();
            this.StadiumNametextBox = new System.Windows.Forms.TextBox();
            this.Foundedlabel = new System.Windows.Forms.Label();
            this.FoundedtextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamID
            // 
            this.TeamID.AutoSize = true;
            this.TeamID.BackColor = System.Drawing.Color.Aqua;
            this.TeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamID.ForeColor = System.Drawing.Color.Black;
            this.TeamID.Location = new System.Drawing.Point(63, 34);
            this.TeamID.Name = "TeamID";
            this.TeamID.Size = new System.Drawing.Size(92, 20);
            this.TeamID.TabIndex = 0;
            this.TeamID.Text = "Team ID :";
            // 
            // TeamIDtextBox
            // 
            this.TeamIDtextBox.Location = new System.Drawing.Point(239, 34);
            this.TeamIDtextBox.Name = "TeamIDtextBox";
            this.TeamIDtextBox.Size = new System.Drawing.Size(126, 22);
            this.TeamIDtextBox.TabIndex = 1;
            this.TeamIDtextBox.TextChanged += new System.EventHandler(this.TeamIDtextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Aqua;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(180, 98);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(106, 29);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 92);
            this.dataGridView1.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Aqua;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(193, 240);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(84, 27);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CountryIDLabel
            // 
            this.CountryIDLabel.AutoSize = true;
            this.CountryIDLabel.BackColor = System.Drawing.Color.Aqua;
            this.CountryIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryIDLabel.ForeColor = System.Drawing.Color.Black;
            this.CountryIDLabel.Location = new System.Drawing.Point(3, 277);
            this.CountryIDLabel.Name = "CountryIDLabel";
            this.CountryIDLabel.Size = new System.Drawing.Size(111, 20);
            this.CountryIDLabel.TabIndex = 6;
            this.CountryIDLabel.Text = "Country ID :";
            // 
            // CountryIDtextBox
            // 
            this.CountryIDtextBox.Location = new System.Drawing.Point(156, 277);
            this.CountryIDtextBox.Name = "CountryIDtextBox";
            this.CountryIDtextBox.Size = new System.Drawing.Size(100, 22);
            this.CountryIDtextBox.TabIndex = 7;
            // 
            // TeamNamelabel
            // 
            this.TeamNamelabel.AutoSize = true;
            this.TeamNamelabel.BackColor = System.Drawing.Color.Aqua;
            this.TeamNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNamelabel.Location = new System.Drawing.Point(3, 343);
            this.TeamNamelabel.Name = "TeamNamelabel";
            this.TeamNamelabel.Size = new System.Drawing.Size(121, 20);
            this.TeamNamelabel.TabIndex = 8;
            this.TeamNamelabel.Text = "Team Name :";
            // 
            // StadiumNamelabel
            // 
            this.StadiumNamelabel.AutoSize = true;
            this.StadiumNamelabel.BackColor = System.Drawing.Color.Aqua;
            this.StadiumNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StadiumNamelabel.Location = new System.Drawing.Point(3, 407);
            this.StadiumNamelabel.Name = "StadiumNamelabel";
            this.StadiumNamelabel.Size = new System.Drawing.Size(143, 20);
            this.StadiumNamelabel.TabIndex = 9;
            this.StadiumNamelabel.Text = "Stadium Name :";
            // 
            // TeamNametextBox
            // 
            this.TeamNametextBox.Location = new System.Drawing.Point(156, 343);
            this.TeamNametextBox.Name = "TeamNametextBox";
            this.TeamNametextBox.Size = new System.Drawing.Size(100, 22);
            this.TeamNametextBox.TabIndex = 10;
            // 
            // StadiumNametextBox
            // 
            this.StadiumNametextBox.Location = new System.Drawing.Point(156, 405);
            this.StadiumNametextBox.Name = "StadiumNametextBox";
            this.StadiumNametextBox.Size = new System.Drawing.Size(100, 22);
            this.StadiumNametextBox.TabIndex = 11;
            // 
            // Foundedlabel
            // 
            this.Foundedlabel.AutoSize = true;
            this.Foundedlabel.BackColor = System.Drawing.Color.Aqua;
            this.Foundedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Foundedlabel.Location = new System.Drawing.Point(263, 312);
            this.Foundedlabel.Name = "Foundedlabel";
            this.Foundedlabel.Size = new System.Drawing.Size(92, 20);
            this.Foundedlabel.TabIndex = 12;
            this.Foundedlabel.Text = "Founded :";
            // 
            // FoundedtextBox
            // 
            this.FoundedtextBox.Location = new System.Drawing.Point(379, 312);
            this.FoundedtextBox.Name = "FoundedtextBox";
            this.FoundedtextBox.Size = new System.Drawing.Size(100, 22);
            this.FoundedtextBox.TabIndex = 13;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Aqua;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(353, 240);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(84, 27);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Team_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.FoundedtextBox);
            this.Controls.Add(this.Foundedlabel);
            this.Controls.Add(this.StadiumNametextBox);
            this.Controls.Add(this.TeamNametextBox);
            this.Controls.Add(this.StadiumNamelabel);
            this.Controls.Add(this.TeamNamelabel);
            this.Controls.Add(this.CountryIDtextBox);
            this.Controls.Add(this.CountryIDLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TeamIDtextBox);
            this.Controls.Add(this.TeamID);
            this.Name = "Team_UserControl";
            this.Size = new System.Drawing.Size(502, 476);
            this.Load += new System.EventHandler(this.Team_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeamID;
        private System.Windows.Forms.TextBox TeamIDtextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label CountryIDLabel;
        private System.Windows.Forms.TextBox CountryIDtextBox;
        private System.Windows.Forms.Label TeamNamelabel;
        private System.Windows.Forms.Label StadiumNamelabel;
        private System.Windows.Forms.TextBox TeamNametextBox;
        private System.Windows.Forms.TextBox StadiumNametextBox;
        private System.Windows.Forms.Label Foundedlabel;
        private System.Windows.Forms.TextBox FoundedtextBox;
        private System.Windows.Forms.Button ClearButton;
    }
}
