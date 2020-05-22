﻿using System;
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
    public partial class UCClientPDF2IMG : UserControl
    {
        public UCClientPDF2IMG()
        {            
            InitializeComponent();
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
            UserControlHelper.SetUserControl(panelClientTask, userControl: new UCPDF2IMGF001(), dockStyle: UserControlDockStyle.DockStyleFill);
        }
        private void btnConvertInFolder_Click(object sender, EventArgs e)
        {
            HideActive();
            PActiveConvertInFolder.Show();
            UserControlHelper.SetUserControl(panelClientTask, userControl: new UCPDF2IMGF002(), dockStyle: UserControlDockStyle.DockStyleFill);
        }
        private void btnConvertInMulFolder_Click(object sender, EventArgs e)
        {
            HideActive();
            PActiveConvertInMulFolder.Show();
            UserControlHelper.SetUserControl(panelClientTask, userControl: new UCPDF2IMGF003(), dockStyle: UserControlDockStyle.DockStyleFill);
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
    }
}