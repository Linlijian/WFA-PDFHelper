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
using IMG2PDF;

namespace WFA.PDFHelper.UserControls
{
    public partial class UCIMG2PDFF001 : UserControl
    {
        private IMG2PDFDA localModel = new IMG2PDFDA();
        public UCIMG2PDFF001()
        {
            InitializeComponent();
        }

        private void UCIMG2PDFF001_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog theDialog = new OpenFileDialog())
            {
                theDialog.Title = "Open Image File";
                theDialog.Filter = "Images |*.JPG";
                theDialog.InitialDirectory = @"C:\";
                theDialog.Multiselect = true;

                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (String file in theDialog.FileNames)
                    {
                        try
                        {
                            //give file namd and path to model
                            //file = D:\testGI\output\71018377_1198760736982570_7540964554520395776_o.jpg
                            var file_name = file.Split('\\');
                            localModel.DTO.Model.IMG2PDFModels.Add(new IMG2PDFModels { FILE_NAME = file_name.Last(), FILE_PATH = file });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            } //end using
                
        }



    }
}
