namespace FIFA_MANAGEMENT_SYSTEM
{
    partial class Player_UserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerIDtextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.LastNametextBox = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.Label();
            this.TeamID = new System.Windows.Forms.Label();
            this.PositiontextBox = new System.Windows.Forms.TextBox();
            this.TeamIDtextBox = new System.Windows.Forms.TextBox();
            this.ViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player ID : ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PlayerIDtextBox
            // 
            this.PlayerIDtextBox.Location = new System.Drawing.Point(209, 13);
            this.PlayerIDtextBox.Name = "PlayerIDtextBox";
            this.PlayerIDtextBox.Size = new System.Drawing.Size(173, 22);
            this.PlayerIDtextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Aqua;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(156, 71);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(106, 29);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(502, 103);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Aqua;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(17, 235);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Aqua;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(122, 235);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(94, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Aqua;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(245, 235);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(103, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Aqua;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(373, 235);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(90, 27);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(14, 301);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(96, 17);
            this.FirstName.TabIndex = 8;
            this.FirstName.Text = "First Name :";
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(260, 304);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(95, 17);
            this.LastName.TabIndex = 9;
            this.LastName.Text = "Last Name :";
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(116, 301);
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(100, 22);
            this.FirstNametextBox.TabIndex = 10;
            // 
            // LastNametextBox
            // 
            this.LastNametextBox.Location = new System.Drawing.Point(363, 301);
            this.LastNametextBox.Name = "LastNametextBox";
            this.LastNametextBox.Size = new System.Drawing.Size(100, 22);
            this.LastNametextBox.TabIndex = 11;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(17, 344);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(46, 17);
            this.Age.TabIndex = 12;
            this.Age.Text = "Age :";
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(116, 344);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(100, 22);
            this.AgetextBox.TabIndex = 13;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position.Location = new System.Drawing.Point(272, 349);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(76, 17);
            this.Position.TabIndex = 14;
            this.Position.Text = "Position :";
            // 
            // TeamID
            // 
            this.TeamID.AutoSize = true;
            this.TeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamID.Location = new System.Drawing.Point(14, 390);
            this.TeamID.Name = "TeamID";
            this.TeamID.Size = new System.Drawing.Size(78, 17);
            this.TeamID.TabIndex = 15;
            this.TeamID.Text = "Team ID :";
            // 
            // PositiontextBox
            // 
            this.PositiontextBox.Location = new System.Drawing.Point(363, 349);
            this.PositiontextBox.Name = "PositiontextBox";
            this.PositiontextBox.Size = new System.Drawing.Size(100, 22);
            this.PositiontextBox.TabIndex = 16;
            // 
            // TeamIDtextBox
            // 
            this.TeamIDtextBox.Location = new System.Drawing.Point(116, 387);
            this.TeamIDtextBox.Name = "TeamIDtextBox";
            this.TeamIDtextBox.Size = new System.Drawing.Size(100, 22);
            this.TeamIDtextBox.TabIndex = 17;
            this.TeamIDtextBox.TextChanged += new System.EventHandler(this.TeamIDtextBox_TextChanged);
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.Color.Aqua;
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(187, 264);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 18;
            this.ViewButton.Text = "VIEW";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // Player_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.TeamIDtextBox);
            this.Controls.Add(this.PositiontextBox);
            this.Controls.Add(this.TeamID);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.AgetextBox);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.LastNametextBox);
            this.Controls.Add(this.FirstNametextBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PlayerIDtextBox);
            this.Controls.Add(this.label1);
            this.Name = "Player_UserControl";
            this.Size = new System.Drawing.Size(502, 476);
            this.Load += new System.EventHandler(this.Player_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlayerIDtextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox FirstNametextBox;
        private System.Windows.Forms.TextBox LastNametextBox;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label TeamID;
        private System.Windows.Forms.TextBox PositiontextBox;
        private System.Windows.Forms.TextBox TeamIDtextBox;
        private System.Windows.Forms.Button ViewButton;
    }
}
