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
            HideSubActiveGeneral();


        }
        public void HideActive()
        {
            PActiveGeneral.Hide();
            PActiveAbout.Hide();
            PActiveUpdate.Hide();
        }
        public void HideSubActiveGeneral()
        {
            this.PActiveUpdate.Location = new Point(0, 239);
            this.PActiveAbout.Location = new Point(0, 198);

            this.btnAbout.Location = new Point(12, 198);
            this.btnUpdate.Location = new Point(12, 239);

            this.button1.Hide();
            this.button2.Hide();
            this.panel1.Hide();
            this.panel2.Hide();
        }
        public void ShowSubActiveGeneral()
        {
            this.PActiveUpdate.Location = new Point(0, 321);
            this.PActiveAbout.Location = new Point(0, 280);

            this.btnAbout.Location = new Point(12, 280);
            this.btnUpdate.Location = new Point(12, 321);

            this.button1.Show();
            this.button2.Show();
            this.panel1.Show();
            this.panel2.Show();
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
            ShowSubActiveGeneral();
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
