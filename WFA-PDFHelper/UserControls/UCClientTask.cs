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
    public partial class UCClientTask : UserControl
    {
        public UCClientTask(string _ActiveTask)
        {            
            InitializeComponent();

            lblActiveTask.Text = _ActiveTask;
            HideActive();

        }
        public void HideActive()
        {
            PActiveConvert2Image.Hide();
            PActiveConvertInFolder.Hide();
            PActiveConvertInMulFolder.Hide();
        }

        private void btnConvert2Image_Click(object sender, EventArgs e)
        {
            HideActive();
            PActiveConvert2Image.Show();

        }

        private void btnConvertInFolder_Click(object sender, EventArgs e)
        {
            HideActive();
            PActiveConvertInFolder.Show();
        }

        private void btnConvertInMulFolder_Click(object sender, EventArgs e)
        {
            HideActive();
            PActiveConvertInMulFolder.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientBody"))
            {
                UCClientBody un = new UCClientBody();
                un.Dock = DockStyle.Fill;
                MainForm.Instance.PnlClientBody.Controls.Add(un);
            }
            MainForm.Instance.PnlClientBody.Controls["UCClientBody"].BringToFront();
            //panelClient.Hide();
            //UserControlHelper.SetUserControl(panelClient, userControl: new UCClientBody(), dockStyle: UserControlDockStyle.DockStyleFill);
        }
    }
}
