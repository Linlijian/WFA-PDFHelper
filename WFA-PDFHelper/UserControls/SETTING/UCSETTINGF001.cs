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
    }
}
