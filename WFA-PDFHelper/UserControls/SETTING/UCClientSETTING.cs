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
        bool ACTIVE = false;
        public UCClientSETTING()
        {
            InitializeComponent();
            //var matches = Controls.Find("PAc", true).FirstOrDefault();
            //matches.Show();

            Global.PActiveHide(panelClient);
        }
        public void HideSubActiveGeneral()
        {
            
        }
        public void ShowSubActiveGeneral()
        {
            
        }
        public void MoveDown() //create static
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
            if (ACTIVE)
            {
                Global.PActiveHide(panelClient);
                HideSubActiveGeneral();

                ACTIVE = false;
            }
            else
            {
                Global.PActiveHide(panelClient);
                PActiveGeneral.Show();
                ShowSubActiveGeneral();
                UserControlHelper.SetUserControl(panelClientTask, userControl: new UCSETTINGF001(), dockStyle: UserControlDockStyle.DockStyleFill);

                ACTIVE = true;
            }
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Global.PActiveHide(panelClient);
            PActiveAbout.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Global.PActiveHide(panelClient);
            PActiveUpdate.Show();
        }

        private void btnCaseSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
