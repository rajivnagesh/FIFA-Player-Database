using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA_MANAGEMENT_SYSTEM
{
    public partial class Setting_UserControl : UserControl
    {
        private static Setting_UserControl _instance;

        public static Setting_UserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Setting_UserControl();

                }
                return _instance;

            }
        }



        public Setting_UserControl()
        {
            InitializeComponent();
        }
    }
}
