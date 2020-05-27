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
            //SaveFileDialog sf = new SaveFileDialog();
            //OpenFileDialog sf = new OpenFileDialog();
            //sf.FileName = "Generate";

            //if (sf.ShowDialog() == DialogResult.OK)
            //{
            //    string savePath = Path.GetDirectoryName(sf.FileName);
            //    lblShowInput.Text = savePath;
            //}
           
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                   
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
