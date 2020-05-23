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
using System.Threading;
using WFA.PlugIn;

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
            btnDeleteImage.Visible = false;
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
                    try
                    {
                        foreach (String file in theDialog.FileNames)
                        {

                            if (regex.IsMatch(file))
                            {
                                var file_name = file.Split('\\');
                                var dup = IMG2PDF.DTO.Model.IMG2PDFModels.Where(t => t.FILE_NAME == file_name.Last()).FirstOrDefault();
                                if (dup.IsNullOrEmpty())
                                    IMG2PDF.DTO.Model.IMG2PDFModels.Add(new IMG2PDFModels { FILE_NAME = file_name.Last(), FILE_PATH = file });
                            }
                        }

                        listboxImage.Items.Clear();
                        foreach (var model in IMG2PDF.DTO.Model.IMG2PDFModels)
                        {
                            listboxImage.Items.Add(model.FILE_NAME);
                        }

                        btnDeleteImage.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }


                }

            }
        } //end using

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            if (listboxImage.SelectedItems.Count > 0)
            {
                foreach(var file in listboxImage.SelectedItems)
                    IMG2PDF.DTO.Model.IMG2PDFModels.RemoveAll(t => t.FILE_NAME == file.ToString());
            }

            listboxImage.Items.Clear();
            foreach (var model in IMG2PDF.DTO.Model.IMG2PDFModels)
            {
                listboxImage.Items.Add(model.FILE_NAME);
            }

            if (listboxImage.Items.Count == 0)
                btnDeleteImage.Visible = false;
        }

        private void savedaa()
        {
            //test
            //using (WaitForm form = new WaitForm(savedaa))
            //{
            //    form.ShowDialog(this);
            //}
            for (int i = 0; i <= 500; i++)
                Thread.Sleep(10);
        }

    }
}
