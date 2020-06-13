using System;
using System.Collections.Generic;
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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WFA.PDFHelper.UserControls
{
    public partial class UCGROUPIMG001 : UserControl
    {
        #region init
        private IMG2PDFDA IMG2PDF = new IMG2PDFDA();

        public UCGROUPIMG001()
        {
            InitializeComponent();
        }
        private void UCGROUPIMG001_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
        }
        #endregion

        #region event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();
            try
            {
                using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
                {
                    dialog.Multiselect = true;
                    dialog.IsFolderPicker = true;
                    dialog.DefaultDirectory = SessionHelper.XML_FOLDER_INPUT;

                    if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                    {
                        foreach (string folder in dialog.FileNames)
                        {
                            IMG2PDF.SelectFolder(folder);
                        }
                    }

                    listboxFolder.Items.Clear();
                    foreach (var item in IMG2PDF.DTO.Model.IMG2FOLDERModels)
                    {
                        for (int i = 0; i < item.SUB_IMG2FOLDERModels.Count(); i++)
                        {
                            listboxFolder.Items.Add(item.FOLDER_NAME + " > " + item.SUB_IMG2FOLDERModels[i].FILE_NAME);
                        }
                    }

                    if (listboxFolder.Items.Count > 0)
                        btnDelete.Visible = true;
                }
            }
            catch (Exception ex)
            {
                ClearFolderError();

                var message = new MassageBoxModel();
                message.TITLE = "Error";
                message.MESSAGE = "Can't find image in folder.\r\nDescription: " + ex.Message;
                message.BUTTON_TYPE = ButtonType.OK;

                using (MassageBox box = new MassageBox(message))
                {
                    box.ShowDialog(this);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //ClearGenerateStatus();
            //if (listboxFolder.SelectedItems.Count > 0)
            //{
            //    foreach (var file in listboxFolder.SelectedItems)
            //        IMG2PDF.DTO.Model.IMG2PDFModels.RemoveAll(t => t.FILE_NAME == file.ToString());
            //}

            //listboxFolder.Items.Clear();
            //foreach (var model in IMG2PDF.DTO.Model.IMG2PDFModels)
            //{
            //    listboxFolder.Items.Add(model.FILE_NAME);
            //}

            //if (listboxFolder.Items.Count == 0)
            //    btnDelete.Visible = false;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //ClearGenerateStatus();
            //var dto = new IMG2PDFDA();
            
            //dto = IMG2PDF;
            //try
            //{
            //    dto.DTO.Model.GenerateType = IMG2PDFGenerateType.UCIMG2PDFF001;
            //    dto.Generate(IMG2PDF.DTO);
            //    lblGenerateStatus.Text = "Generate Complete!";
            //}
            //catch (Exception ex)
            //{
            //    var message = new MassageBoxModel();
            //    message.TITLE = "Error";
            //    message.MESSAGE = "Please re-check to generate pdf.\r\nDescription: " + ex.Message;
            //    message.BUTTON_TYPE = ButtonType.OK;

            //    using (MassageBox box = new MassageBox(message))
            //    {
            //        box.ShowDialog(this);
            //    }
            //}
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
        private void ClearFolderError()
        {
            var err = IMG2PDF.DTO.Model.IMG2FOLDERModels.Where(w => w.SUB_IMG2FOLDERModels.IsNullOrEmpty()).FirstOrDefault();
            IMG2PDF.DTO.Model.IMG2FOLDERModels.Remove(err);
        }
        #endregion
    }
}
