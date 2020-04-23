using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace FIFA_MANAGEMENT_SYSTEM
{
    public partial class AppBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();









        public AppBody()
        {
            InitializeComponent();
            //initializations for sliding panel
            isSlidingPanelExpanded = true;
            expandSlidingPanelGUI();


        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_in_Timer.Start();
        }

        private void Log_in_Timer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<=1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                Log_in_Timer.Stop();

            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void expandSlidingPanelGUI()
        {
            //gui adjustments for expanding
            PlayerTabButton.Text = "PLAYER";
            TeamTabButton.Text = "TEAM";
            CountryTabButton.Text = "COUNTRY";
            SettingsTabButton.Text = "SETTINGS";
            AboutTabButton.Text = "ABOUT";

            SlidingPanel_ToggleButton.Image = Properties.Resources.left;

            PlayerTabButton.Image = null;
            TeamTabButton.Image = null;
            CountryTabButton.Image = null;
            SettingsTabButton.Image = null;
            AboutTabButton.Image = null;



        }

        public void retractSlidingPanelGUI()
        {
            //gui adjustments for retracting
            PlayerTabButton.Text = "";
            TeamTabButton.Text = "";
            CountryTabButton.Text = "";
            SettingsTabButton.Text = "";
            AboutTabButton.Text = "";

            SlidingPanel_ToggleButton.Image = Properties.Resources.right;

            PlayerTabButton.Image = Properties.Resources.players;
            TeamTabButton.Image = Properties.Resources.team;
            CountryTabButton.Image = Properties.Resources.flag;
            SettingsTabButton.Image = Properties.Resources.gear;
            AboutTabButton.Image = Properties.Resources.info;



        }




        //sliding panel code starts from here
        bool isSlidingPanelExpanded;
        const int MaxSliderWidth=220;
        const int MinSliderWidth=75;


        private void SlidingPanel_ToggleButton_Click(object sender, EventArgs e)
        {
            if(isSlidingPanelExpanded)
            {
                //retract panel
                retractSlidingPanelGUI();
            }
            SlidingPanel_Timer.Start();
        }

        private void SlidingPanel_Timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                //retract panel
                SlidingPanel.Width -= 30;
                if(SlidingPanel.Width <= MinSliderWidth)
                {
                    //stop retract
                    isSlidingPanelExpanded = false;
                    SlidingPanel_Timer.Stop();

                    this.Refresh();


                }
            }
            else
            {
                //expand the panel
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width >= MaxSliderWidth)
                {
                    //stop expanding
                    isSlidingPanelExpanded = true;
                    SlidingPanel_Timer.Stop();
                    expandSlidingPanelGUI();
                    this.Refresh();


                }

            }
        }

        private void PlayerTabButton_Click(object sender, EventArgs e)
        {
            if(! ContentPanel.Controls.Contains(Player_UserControl.Instance))
            {
                //creating instance
                ContentPanel.Controls.Add(Player_UserControl.Instance);
                Player_UserControl.Instance.Dock = DockStyle.Fill;
                Player_UserControl.Instance.BringToFront();
            }
            else
            {
                Player_UserControl.Instance.BringToFront();
            }
        }

        private void TeamTabButton_Click(object sender, EventArgs e)
        {
            if(! ContentPanel.Controls.Contains(Team_UserControl.Instance))
            {
                //creating instance
                ContentPanel.Controls.Add(Team_UserControl.Instance);
                Team_UserControl.Instance.Dock= DockStyle.Fill;
                Team_UserControl.Instance.BringToFront();

            }
            else
            {
                Team_UserControl.Instance.BringToFront();
            }
        }

        private void CountryTabButton_Click(object sender, EventArgs e)
        {
            if(! ContentPanel.Controls.Contains(Country_UserControl.Instance))
            {
                //creating instance
                ContentPanel.Controls.Add(Country_UserControl.Instance);
                Country_UserControl.Instance.Dock = DockStyle.Fill;
                Country_UserControl.Instance.BringToFront();

            }
            else
            {
                Country_UserControl.Instance.BringToFront();
            }
        }

        private void SettingsTabButton_Click(object sender, EventArgs e)
        {
            if(! ContentPanel.Controls.Contains(Setting_UserControl.Instance))
            {
                //creating instance
                ContentPanel.Controls.Add(Setting_UserControl.Instance);
                Setting_UserControl.Instance.Dock = DockStyle.Fill;
                Setting_UserControl.Instance.BringToFront();

            }
            else
            {
                Setting_UserControl.Instance.BringToFront();
            }
        }

        private void AboutTabButton_Click(object sender, EventArgs e)
        {
            if(! ContentPanel.Controls.Contains(About_UserControl.Instance))
            {
                //creating instance
                ContentPanel.Controls.Add(About_UserControl.Instance);
                About_UserControl.Instance.Dock = DockStyle.Fill;
                About_UserControl.Instance.BringToFront();

            }
            else
            {
                About_UserControl.Instance.BringToFront();
            }
        }
    }
}
