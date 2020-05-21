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
    public partial class UCIMG2PDFF001 : UserControl
    {
        public UCIMG2PDFF001()
        {
            InitializeComponent();
        }

        private void UCIMG2PDFF001_Load(object sender, EventArgs e)
        {
           // btnAddImage.FlatAppearance.BorderColor = Color.DarkRed;
            //button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void btnAddImage_MouseHover(object sender, EventArgs e)
        {
           // btnAddImage.FlatAppearance.BorderColor = Color.DarkRed;
        }
    }
}
