using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMG2PDF;
using WFA.PlugIn;
using UtilityLib;
using System.Text.RegularExpressions;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WFA.PDFHelper.UserControls
{
    public partial class UCIMG2PDFF002 : UserControl
    {
        #region init
        private IMG2PDFDA IMG2PDF = new IMG2PDFDA();
        private int SORT_TOGGLE_ON = 0;

        public UCIMG2PDFF002()
        {
            InitializeComponent();
        }
        private void UCIMG2PDFF002_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            SORT_TOGGLE_ON = 1; //false
        }
        #endregion

        #region event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();
            try {
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

                    listboxImage.Items.Clear();
                    foreach (var item in IMG2PDF.DTO.Model.IMG2FOLDERModels)
                    {
                        for (int i = 0; i < item.SUB_IMG2FOLDERModels.Count(); i++)
                        {
                            listboxImage.Items.Add(item.FOLDER_NAME + " > " + item.SUB_IMG2FOLDERModels[i].FILE_NAME);
                        }
                    }

                    if (listboxImage.Items.Count > 0)
                        btnDelete.Visible = true;
                }
            }
            catch(Exception ex)
            {
                ClearFolderError();
                if (listboxImage.Items.Count > 0)
                    btnDelete.Visible = true;

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
            ClearGenerateStatus();
            if (listboxImage.SelectedItems.Count > 0)
            {
                foreach (var file in listboxImage.SelectedItems)
                {
                    var spl = file.ToString().Split(new string[] { " > " }, StringSplitOptions.None);
                    var folder = IMG2PDF.DTO.Model.IMG2FOLDERModels.Where(l => l.FOLDER_NAME == spl.First()).FirstOrDefault();
                    var remove = folder.SUB_IMG2FOLDERModels.Where(m => m.FILE_NAME == spl.Last()).FirstOrDefault();
                    folder.SUB_IMG2FOLDERModels.Remove(remove);

                    IMG2PDF.DTO.Model.IMG2FOLDERModels.MergeObject(folder);

                    if(folder.SUB_IMG2FOLDERModels.Count() == 0)
                        IMG2PDF.DTO.Model.IMG2FOLDERModels.Remove(folder);
                }
            }

            listboxImage.Items.Clear();
            foreach (var item in IMG2PDF.DTO.Model.IMG2FOLDERModels)
            {
                for (int i = 0; i < item.SUB_IMG2FOLDERModels.Count(); i++)
                {
                    listboxImage.Items.Add(item.FOLDER_NAME + " > " + item.SUB_IMG2FOLDERModels[i].FILE_NAME);
                }
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
            IMG2PDF.DTO.Model.SORT = SORT_TOGGLE_ON == 0 ? true : false;
          
            using (WaitForm form = new WaitForm(Generate))
            {
                form.ShowDialog(this);
            }

            if (IMG2PDF.DTO.ErrorResults.ERROR_CODE < 0)
            {
                var message = new MassageBoxModel();
                message.TITLE = "Error";
                message.MESSAGE = "Please re-check to Generate PDF.\r\nDescription: " + IMG2PDF.DTO.ErrorResults.ERROR_MESSAGE;
                message.BUTTON_TYPE = ButtonType.OK;

                using (MassageBox box = new MassageBox(message))
                {
                    box.ShowDialog(this);
                }

                return;
            }

            lblGenerateStatus.Text = "Generate Complete!";
            GenerateResult();
        }
        #endregion

        #region method
        private void Generate()
        {
            var dto = new IMG2PDFDA();
            dto = IMG2PDF;

            try
            {
                dto.DTO.Model.GenerateType = IMG2PDFGenerateType.IMG2PDFF002SORT;
                dto.GenerateEx(IMG2PDF.DTO);

                dto.DTO.Model.GenerateType = IMG2PDFGenerateType.UCIMG2PDFF002;
                int folderCount = IMG2PDF.DTO.Model.IMG2FOLDERModels.Count();
                for (int i = 0; i < folderCount; i++)
                {
                    var folder = IMG2PDF.DTO.Model.IMG2FOLDERModels[i];
                    FileDuplicate(folder.FOLDER_NAME);

                    if (SessionHelper.SYS_DIALOG_RESULT)
                    {
                        IMG2PDF.DTO.Model.FOLDER_COUNT = i;
                        dto.Generate(IMG2PDF.DTO);
                    }

                }
                IMG2PDF.DTO.ErrorResults.ERROR_CODE = 0;
            }
            catch (Exception ex)
            {
                IMG2PDF.DTO.ErrorResults.ERROR_CODE = -1;
                IMG2PDF.DTO.ErrorResults.ERROR_MESSAGE = ex.Message;
            }
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
        private string GenerateFileName(string folder)
        {
            return SessionHelper.XML_FOLDER_OUTPUT + "\\" + folder + ".pdf";
        }
        private void GenerateResult()
        {
            IMG2PDF.DTO.Results.Clear();
            int folderCount = IMG2PDF.DTO.Model.IMG2FOLDERModels.Count();
            for (int i = 0; i < folderCount; i++)
            {
                var code = IMG2PDF.DTO.Model.IMG2FOLDERModels[i].FOLDER_NAME;
                var folder = IMG2PDF.DTO.Model.IMG2FOLDERModels[i].FOLDER_PATH.Split('\\');
                IMG2PDF.DTO.Results.Add(new Results { CODE = "'" + code, FOLDER = "'" + folder[folder.Count() - 2] });
            }

            using (ResultList box = new ResultList(IMG2PDF.DTO.Results))
            {
                box.ShowDialog(this);
            }
        }
        private void FileDuplicate(string filename)
        {
            var CFile = Directory.GetFiles(SessionHelper.XML_FOLDER_OUTPUT).Count();
            var CFound = 0;
            if (CFile > 0)
            {
                for(int i = 0; i < CFile; i++)
                {
                    var file = Directory.GetFiles(SessionHelper.XML_FOLDER_OUTPUT);
                    if (file[i] == GenerateFileName(filename))
                    {
                        filename = file[i].Split('\\').Last();
                        CFound += CFile;
                    }
                }
                

                if(CFound >= CFile)
                {
                    if (SessionHelper.XML_DUP_FILE == "1")
                    {
                        var message = new MassageBoxModel();
                        message.TITLE = "Infomation";
                        message.MESSAGE = "The destination already has file name \"" + filename + "\"\r\nAre you replace the file in the destination?";
                        message.BUTTON_TYPE = ButtonType.OK_CANCEL;

                        using (MassageBox box = new MassageBox(message))
                        {
                            box.ShowDialog(this);
                        }

                        return;
                    }
                }
            }

            SessionHelper.SYS_DIALOG_RESULT = true;
        }
        #endregion        
    }
}
