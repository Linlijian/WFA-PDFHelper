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
    public partial class UCClientSETTING : UserControl
    {
        public UCClientSETTING()
        {
            InitializeComponent();
            HideActive();
        }
        public void HideActive()
        {
            PActiveGeneral.Hide();
            PActiveAbout.Hide();
            PActiveUpdate.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlTitle.BackColor = Color.Black;
            if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientBody"))
            {
                UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientBody(), dockStyle: UserControlDockStyle.DockStyleFill);
            }
            MainForm.Instance.PnlClientBody.Controls["UCClientBody"].BringToFront();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            HideActive();
            PActiveGeneral.Show();
            UserControlHelper.SetUserControl(panelClientTask, userControl: new UCSETTINGF001(), dockStyle: UserControlDockStyle.DockStyleFill);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            HideActive();
            PActiveAbout.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HideActive();
            PActiveUpdate.Show();
        }
    }
}
