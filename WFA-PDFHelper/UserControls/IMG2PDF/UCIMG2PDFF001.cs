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
        #region init
        private IMG2PDFDA IMG2PDF = new IMG2PDFDA();
        private int SORT_TOGGLE_ON = 0;

        public UCIMG2PDFF001()
        {
            InitializeComponent();
        }
        private void UCIMG2PDFF001_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            SORT_TOGGLE_ON = 1; //false
        }
        #endregion

        #region event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();
            using (OpenFileDialog theDialog = new OpenFileDialog())
            {
                var regex = new Regex("(.*)(?=.*.JPG|.*.JPEG|.*.jpg|.*.jpeg)");

                theDialog.Title = "Select Image File";
                theDialog.Filter = "JPEG| *.JPG;*.JPEG*.jpg;*.jpeg";
                theDialog.InitialDirectory = SessionHelper.XML_FOLDER_INPUT;
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

                        btnDelete.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        var message = new MassageBoxModel();
                        message.TITLE = "Error";
                        message.MESSAGE = "Error add image.\r\nDescription: " + ex.Message;
                        message.BUTTON_TYPE = ButtonType.OK;

                        using (MassageBox box = new MassageBox(message))
                        {
                            box.ShowDialog(this);
                        }
                    }
                }

            }//end using
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();
            if (listboxImage.SelectedItems.Count > 0)
            {
                foreach (var file in listboxImage.SelectedItems)
                    IMG2PDF.DTO.Model.IMG2PDFModels.RemoveAll(t => t.FILE_NAME == file.ToString());
            }

            listboxImage.Items.Clear();
            foreach (var model in IMG2PDF.DTO.Model.IMG2PDFModels)
            {
                listboxImage.Items.Add(model.FILE_NAME);
            }

            if (listboxImage.Items.Count == 0)
                btnDelete.Visible = false;
        }
        private void btnSortImage_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();
            if (SORT_TOGGLE_ON != 0) 
            {
                //on
                btnSortImage.BackgroundImage = global::WFA_PDFHelper.Properties.Resources.toggle_on_32px;
                lblSwitchSortImage.Text = "On";
                SORT_TOGGLE_ON = 0;
            }
            else
            {
                //off
                btnSortImage.BackgroundImage = global::WFA_PDFHelper.Properties.Resources.toggle_off_32px;
                lblSwitchSortImage.Text = "Off";
                SORT_TOGGLE_ON = 1;
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();
            var dto = new IMG2PDFDA();

            IMG2PDF.DTO.Model.SORT = SORT_TOGGLE_ON == 0 ? true : false;
            dto = IMG2PDF;
            try
            {
                dto.DTO.Model.GenerateType = IMG2PDFGenerateType.UCIMG2PDFF001;
                dto.Generate(IMG2PDF.DTO);
                lblGenerateStatus.Text = "Generate Complete!";
            }
            catch(Exception ex)
            {
                var message = new MassageBoxModel();
                message.TITLE = "Error";
                message.MESSAGE = "Please re-check to generate pdf.\r\nDescription: " + ex.Message;
                message.BUTTON_TYPE = ButtonType.OK;

                using (MassageBox box = new MassageBox(message))
                {
                    box.ShowDialog(this);
                }
            }
        }
        #endregion

        #region method        
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
        private void ClearGenerateStatus()
        {
            lblGenerateStatus.Text = "";
        }
        #endregion

    }
}
