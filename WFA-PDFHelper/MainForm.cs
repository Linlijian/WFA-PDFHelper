using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA.PDFHelper.Helper;
using WFA.PDFHelper.UserControls;

namespace WFA.PDFHelper
{
    public partial class MainForm : Form
    {
        #region Move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region init
        static MainForm _obj;

        public static MainForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainForm();
                }
                return _obj;
            }
        }

        public Panel PnlClientBody
        {
            get { return panelClientBody; }
            set { panelClientBody = value; }
        }
        public Panel PnlTitle
        {
            get { return panelTitle; }
            set { panelTitle = value; }
        }

        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region form
        private void MainForm_Load(object sender, EventArgs e)
        {
            _obj = this;
            UserControlHelper.SetUserControl(panelClientBody, userControl: new UCClientBody(),dockStyle:UserControlDockStyle.DockStyleFill);
        }
        #endregion

        #region btn
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region panel

        #endregion

        private void btnHome_Click(object sender, EventArgs e)
        {
            PnlClientBody.Controls["UCClientBody"].BringToFront();
        }
    }
}
