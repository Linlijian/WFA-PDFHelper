using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA.PDFHelper.Helper;

namespace WFA.PDFHelper.UserControls
{
    public partial class UCClientBody : UserControl
    {
        public UCClientBody()
        {
            InitializeComponent();
        }

        private void btnPDFtoImage_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientTask"))
            {
                UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientTask(), dockStyle: UserControlDockStyle.DockStyleFill);
            }
            MainForm.Instance.PnlClientBody.Controls["UCClientTask"].BringToFront();
            //MainForm.Instance.ButtonHome.Visible = true;
            //UserControlHelper.SetUserControl(MainForm.pa, userControl: new UCPDF2Image(), dockStyle: UserControlDockStyle.DockStyleFill);
        }
    }
}
