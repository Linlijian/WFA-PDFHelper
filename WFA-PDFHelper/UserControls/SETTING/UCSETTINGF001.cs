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

namespace WFA.PDFHelper.UserControls
{
    public partial class UCSETTINGF001 : UserControl
    {
        public UCSETTINGF001()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = "";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                string savePath = Path.GetDirectoryName(sf.FileName);
                string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                // Do whatever
            }
        }
        private void savedaa()
        {
            
            for (int i = 0; i <= 500; i++)
                Thread.Sleep(10);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //test
            using (WaitForm form = new WaitForm(savedaa))
            {
                form.ShowDialog(this);
            }
        }
    }
}
