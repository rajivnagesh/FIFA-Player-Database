using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FIFA_MANAGEMENT_SYSTEM
{

    public partial class Player_UserControl : UserControl
    {
        private static Player_UserControl _instance;

        public static Player_UserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Player_UserControl();

                }
                return _instance;

            }

        }


        public Player_UserControl()
        {
            InitializeComponent();
        }



        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");



        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PlayerIDtextBox.Text = "";
            FirstNametextBox.Text = "";
            LastNametextBox.Text = "";
            AgetextBox.Text = "";
            PositiontextBox.Text = "";
            TeamIDtextBox.Text = "";

        }


        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllPlayersData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("                <<<INVALID SQL OPERATION>>> :\n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //this.dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("PlayerADD_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@First_Name",FirstNametextBox.Text);
            cmd.Parameters.AddWithValue("@Last_Name", LastNametextBox.Text);
            cmd.Parameters.AddWithValue("@Age", AgetextBox.Text);
            cmd.Parameters.AddWithValue("@Position", PositiontextBox.Text);
            cmd.Parameters.AddWithValue("@Team_ID_FK", TeamIDtextBox.Text);
            //cmd.Parameters.AddWithValue("@Country_ID_FK", CountryIDtextBox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("                <<<INVALID SQL OPERATION>>> :\n" + ex);

            }
     
            con.Close();
            refresh_DataGridView();


        }

        private void Player_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Player SET First_Name = '"+FirstNametextBox.Text+"', Last_Name = '"+LastNametextBox.Text+"', Age = '"+AgetextBox.Text+"', Position = '"+PositiontextBox.Text+"' WHERE Player_ID = '"+PlayerIDtextBox.Text+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updation Successful!!");

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PlayersDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Player_ID", PlayerIDtextBox.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("           <<<INVALID SQL OPERATION>>>: \n" + ex);

                }
                con.Close();
                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PlayerSearch_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Player_ID", PlayerIDtextBox.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("                <<<INVALID SQL OPERATION>>> :\n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
        }

        private void TeamIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            PlayerIDtextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           FirstNametextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            LastNametextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            AgetextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PositiontextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            TeamIDtextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString(); 
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
    }
}
