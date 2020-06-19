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
    public partial class UCIMG2PDFF003 : UserControl
    {
        #region init
        private IMG2PDFDA IMG2PDF = new IMG2PDFDA();
        private int SORT_TOGGLE_ON = 0;

        public UCIMG2PDFF003()
        {
            InitializeComponent();
        }
        private void UCIMG2PDFF003_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            SORT_TOGGLE_ON = 1; //false
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
                            IMG2PDF.SelectFolders(folder);
                        }
                    }

                    listboxImage.Items.Clear();
                    string strShowList = string.Empty;

                    for (int i = 0; i < IMG2PDF.DTO.Model.IMG2FOLDERModels.Count(); i++)
                    {
                        var models = IMG2PDF.DTO.Model.IMG2FOLDERModels[i].SUB_IMG2FOLDERModels.GroupBy(t => new { t.SUB_FOLDER_NAME })
                                      .Select(group => new { SUB_FOLDER = group.Key, ARR = group.ToArray() })
                                      .ToList();
                        for (int x = 0; x < models.Count; x++)
                        {
                            for (int y = 0; y < models[x].ARR.Count(); y++)
                            {
                                foreach (var arr in models[x].ARR[y].ARRAY_FOLDER)
                                {
                                    if (models[x].ARR[y].ARRAY_FOLDER.Last() != arr)
                                    {
                                        strShowList += arr + "=>";
                                    }
                                    else
                                    {
                                        strShowList += arr + "=>" + models[x].ARR[y].FILE_NAME;
                                    }
                                }
                                listboxImage.Items.Add(IMG2PDF.DTO.Model.IMG2FOLDERModels[i].FOLDER_NAME
                                                                          + " > " + strShowList);
                                strShowList = string.Empty;
                            }
                        }

                    }

                    if (listboxImage.Items.Count > 0)
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
            ClearGenerateStatus();
            if (listboxImage.SelectedItems.Count > 0)
            {
                foreach (var file in listboxImage.SelectedItems)
                {
                    var spl = file.ToString().Split(new string[] { " > ", "=>" }, StringSplitOptions.None);
                    var LootFolder = IMG2PDF.DTO.Model.IMG2FOLDERModels.Where(l => l.FOLDER_NAME == spl.First()).FirstOrDefault();
                    var SubFolder = LootFolder.SUB_IMG2FOLDERModels.Where(w => w.FILE_NAME == spl.Last()).ToList();

                    foreach (var remove in SubFolder)
                    {
                        LootFolder.SUB_IMG2FOLDERModels.Remove(remove);
                    }

                    IMG2PDF.DTO.Model.IMG2FOLDERModels.MergeObject(LootFolder);

                    if (LootFolder.SUB_IMG2FOLDERModels.Count() == 0)
                        IMG2PDF.DTO.Model.IMG2FOLDERModels.Remove(LootFolder);
                }
            }

            listboxImage.Items.Clear();
            string strShowList = string.Empty;

            for (int i = 0; i < IMG2PDF.DTO.Model.IMG2FOLDERModels.Count(); i++)
            {
                var models = IMG2PDF.DTO.Model.IMG2FOLDERModels[i].SUB_IMG2FOLDERModels.GroupBy(t => new { t.SUB_FOLDER_NAME })
                              .Select(group => new { SUB_FOLDER = group.Key, ARR = group.ToArray() })
                              .ToList();
                for (int x = 0; x < models.Count; x++)
                {
                    for (int y = 0; y < models[x].ARR.Count(); y++)
                    {
                        foreach (var arr in models[x].ARR[y].ARRAY_FOLDER)
                        {
                            if (models[x].ARR[y].ARRAY_FOLDER.Last() != arr)
                            {
                                strShowList += arr + "=>";
                            }
                            else
                            {
                                strShowList += arr + "=>" + models[x].ARR[y].FILE_NAME;
                            }
                        }
                        listboxImage.Items.Add(IMG2PDF.DTO.Model.IMG2FOLDERModels[i].FOLDER_NAME
                                                                  + " > " + strShowList);
                        strShowList = string.Empty;
                    }
                }

            }
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
                message.MESSAGE = "Please re-check to Generate group image.\r\nDescription: " + IMG2PDF.DTO.ErrorResults.ERROR_MESSAGE;
                message.BUTTON_TYPE = ButtonType.OK;

                using (MassageBox box = new MassageBox(message))
                {
                    box.ShowDialog(this);
                }

                return;
            }

            lblGenerateStatus.Text = "Generate Complete!";
        }
        #endregion

        #region method
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
        private void FileDuplicate(string filename)
        {
            var CFile = Directory.GetFiles(SessionHelper.XML_FOLDER_OUTPUT).Count();
            var CFound = 0;
            if (CFile > 0)
            {
                for (int i = 0; i < CFile; i++)
                {
                    var file = Directory.GetFiles(SessionHelper.XML_FOLDER_OUTPUT);
                    if (file[i] == GenerateFileName(filename))
                    {
                        filename = file[i].Split('\\').Last();
                        CFound += CFile;
                    }
                }


                if (CFound >= CFile)
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
        private void Generate()
        {
            var dto = new IMG2PDFDA();
            dto = IMG2PDF;

            try
            {
                dto.DTO.Model.GenerateType = IMG2PDFGenerateType.IMG2PDFF003SORT;
                dto.GenerateEx(IMG2PDF.DTO);

                dto.DTO.Model.GenerateType = IMG2PDFGenerateType.UCIMG2PDFF003;
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
        #endregion        
    }
}
