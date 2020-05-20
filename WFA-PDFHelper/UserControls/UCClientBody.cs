using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.PDFHelper.UserControls
{
    public partial class UCClientBody : UserControl
    {
        public UCClientBody()
        {
            InitializeComponent();
        }

        private void btnPDFtoImage_Click(object sender, EventArgs e)
        {
            //UserControlHelper.SetUserControl(MainForm.pa, userControl: new UCPDF2Image(), dockStyle: UserControlDockStyle.DockStyleFill);
        }
    }
}
