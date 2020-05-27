using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using WFA.PlugIn;
using UtilityLib;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WFA.PDFHelper.UserControls
{
    public partial class UCSETTINGF001 : UserControl
    {
        public UCSETTINGF001()
        {
            InitializeComponent();
        }
        private void UCSETTINGF001_Load(object sender, EventArgs e)
        {
            lblShowInput.Text = SessionHelper.XML_FOLDER_OUTPUT;
        }

        private void btnAddInputPath_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.InitialDirectory = lblShowInput.Text;
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    lblShowInput.Text = dialog.FileName;
                }
            }
                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save xml
            //load to sassion
        }
    }
}
