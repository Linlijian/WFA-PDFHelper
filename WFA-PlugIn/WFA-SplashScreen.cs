using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;
using WFA.PlugIn;

namespace WFA_PlugIn
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            VerifyStartUp();
        }
        private bool VerifyStartUp()
        {
            return SessionHelper.SYS_StartUp = true;
        }

    }
}
