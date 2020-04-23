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
    public partial class Country_UserControl : UserControl
    {
        private static Country_UserControl _instance;

        public static Country_UserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Country_UserControl();

                }
                return _instance;
            }
        }

        public Country_UserControl()
        {
            InitializeComponent();
        }
    }
}
