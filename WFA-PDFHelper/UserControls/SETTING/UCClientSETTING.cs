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

            Global.PActiveHide(panelClient);
            Global.PSActiveHide(panelClient);
            Global.PHideMenu(PSubGeneral);
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
                Global.PSActiveHide(panelClient);
                Global.PHideMenu(PSubGeneral);

                ACTIVE = false;
            }
            else
            {
                Global.PActiveHide(panelClient);
                Global.PActiveShow(PActiveGeneral);
                Global.PShowMenu(PSubGeneral);
                UserControlHelper.SetUserControl(panelClientTask, userControl: new UCSETTINGF001(), dockStyle: UserControlDockStyle.DockStyleFill);

                ACTIVE = true;
            }
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Global.PActiveHide(panelClient);
            Global.PSActiveHide(panelClient);
            Global.PActiveShow(PActiveAbout);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Global.PActiveHide(panelClient);
            Global.PSActiveHide(panelClient);
            Global.PActiveShow(PActiveUpdate);
        }

        private void btnCaseSelect_Click(object sender, EventArgs e)
        {
            Global.PSActiveHide(panelClient);
            Global.PSActiveShow(PSActiveCaseSelect);
            UserControlHelper.SetUserControl(panelClientTask, userControl: new UCSETTINGF1S01(), dockStyle: UserControlDockStyle.DockStyleFill);
        }
    }
}
