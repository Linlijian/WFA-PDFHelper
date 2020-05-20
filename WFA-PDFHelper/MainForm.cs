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
        //public Button HomeButton
        //{
        //    get { return btnHome; }
        //    set { btnHome = value; }
        //}

        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region form
        private void MainForm_Load(object sender, EventArgs e)
        {
            _obj = this;

            //UserControlHelper.SetUserControl(panelClientBody, userControl: new UCClientBody(),dockStyle:UserControlDockStyle.DockStyleFill);
        }
        #endregion

        #region btn
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatAppearance.MouseDownBackColor = Color.DarkRed;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region panel

        #endregion

        private void btnPDFtoImage_Click(object sender, EventArgs e)
        {
            string ActiveTask = "PDF to Image";

            if (!PnlClientBody.Controls.ContainsKey("UCClientTask"))
            {
                UCClientTask un = new UCClientTask(ActiveTask);
                un.Dock = DockStyle.Fill;
                PnlClientBody.Controls.Add(un);
            }
            PnlClientBody.Controls["UCClientTask"].BringToFront();

            // UserControlHelper.SetUserControl(panelClientBody, userControl: new UCClientTask(ActiveTask), dockStyle: UserControlDockStyle.DockStyleFill);
        }
    }
}
