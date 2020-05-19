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
    public partial class UCTopHeaderTitle : UserControl
    {
        public UCTopHeaderTitle()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            //close form
            ((Form)this.TopLevelControl).Close();
        }
    }
}
