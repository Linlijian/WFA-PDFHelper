using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDF2IMG;
using System.Text.RegularExpressions;
using UtilityLib;
using WFA.PlugIn;
using System.Drawing.Imaging;

namespace WFA.PDFHelper.UserControls
{
    public partial class UCPDF2IMGF001 : UserControl
    {
        #region init
        private PDF2IMGDA PDF2IMG = new PDF2IMGDA();

        public UCPDF2IMGF001()
        {
            InitializeComponent();
        }
        private void UCPDF2IMGF001_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
        }
        #endregion

        #region event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();
            using (OpenFileDialog theDialog = new OpenFileDialog())
            {
                var regex = new Regex("(.*)(?=.*.PDF|.*.pdf)");

                theDialog.Title = "Select Image File";
                theDialog.Filter = "PDF| *.pdf;*.PDF";
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
                                PDF2IMG.DTO.Model.FILE_PATH = file;
                                PDF2IMG.DTO.Model.FILE_NAME = file_name.Last();
                                PDF2IMG.DTO.Model.IMAGE_FORMAT = ImageFormat.Jpeg; //type
                                PDF2IMG.DTO.Model.Definition = Definition.Five; //size

                                PDF2IMG.DTO.Models.Add(new PDF2IMGModel {
                                    FILE_PATH = file,
                                    FILE_NAME = file_name.Last(),
                                    IMAGE_FORMAT = ImageFormat.Jpeg, //type
                                    Definition = Definition.Five //size
                            });
                            }
                        }

                        listboxImage.Items.Clear();
                        foreach (var model in PDF2IMG.DTO.Models)
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
                    PDF2IMG.DTO.Models.RemoveAll(t => t.FILE_NAME == file.ToString());
            }

            listboxImage.Items.Clear();
            foreach (var model in PDF2IMG.DTO.Models)
            {
                listboxImage.Items.Add(model.FILE_NAME);
            }

            if (listboxImage.Items.Count == 0)
                btnDelete.Visible = false;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();

            using (WaitForm form = new WaitForm(Generate))
            {
                form.ShowDialog(this);
            }

            if (PDF2IMG.DTO.ErrorResults.ERROR_CODE < 0)
            {
                var message = new MassageBoxModel();
                message.TITLE = "Error";
                message.MESSAGE = "Please re-check to Generate PDF.\r\nDescription: " + PDF2IMG.DTO.ErrorResults.ERROR_MESSAGE;
                message.BUTTON_TYPE = ButtonType.OK;

                using (MassageBox box = new MassageBox(message))
                {
                    box.ShowDialog(this);
                }

                return;
            }

            GenerateResult();
            lblGenerateStatus.Text = "Generate Complete!";
        }
        #endregion

        #region method        
        private void Generate()
        {
            var dto = new PDF2IMGDA();
            dto = PDF2IMG;

            try
            {
                dto.DTO.Model.GenerateType = PDF2IMGGenerateType.UCPDF2IMGF001;
                dto.Generate(PDF2IMG.DTO);
                PDF2IMG.DTO.ErrorResults.ERROR_CODE = 0;
            }
            catch (Exception ex)
            {
                PDF2IMG.DTO.ErrorResults.ERROR_CODE = -1;
                PDF2IMG.DTO.ErrorResults.ERROR_MESSAGE = ex.Message;
            }
        }
        private void ClearGenerateStatus()
        {
            lblGenerateStatus.Text = "";
        }
        private void GenerateResult()
        {
            var message = new MassageBoxModel();
            message.TITLE = "Info";
            message.MESSAGE = "Coomplete";
            message.BUTTON_TYPE = ButtonType.OK;

            using (MassageBox box = new MassageBox(message))
            {
                box.ShowDialog(this);
            }
        }
        #endregion
    }
}
