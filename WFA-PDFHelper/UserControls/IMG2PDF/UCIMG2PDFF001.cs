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
using System.Text.RegularExpressions;
using UtilityLib;

namespace WFA.PDFHelper.UserControls
{
    public partial class UCIMG2PDFF001 : UserControl
    {
        private IMG2PDFDA IMG2PDF = new IMG2PDFDA();
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
                var regex = new Regex("(.*)(?=.*.JPG|.*.JPEG|.*.jpg|.*.jpeg)");

                theDialog.Title = "Open Image File";
                theDialog.Filter = "JPEG| *.JPG;*.JPEG*.jpg;*.jpeg";
                theDialog.InitialDirectory = @"C:\";
                theDialog.Multiselect = true;

                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (String file in theDialog.FileNames)
                    {
                        try
                        {
                            if (regex.IsMatch(file))
                            {
                                var file_name = file.Split('\\');
                                var dup = IMG2PDF.DTO.Model.IMG2PDFModels.Where(t=>t.FILE_NAME == file_name.Last()).FirstOrDefault();
                                if(dup.IsNullOrEmpty())
                                    IMG2PDF.DTO.Model.IMG2PDFModels.Add(new IMG2PDFModels { FILE_NAME = file_name.Last(), FILE_PATH = file });
                            }                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                    listboxImage.Items.Clear();
                    foreach (var model in IMG2PDF.DTO.Model.IMG2PDFModels)
                    {
                        listboxImage.Items.Add(model.FILE_NAME);
                    }
                }
            } //end using
                
        }



    }
}
