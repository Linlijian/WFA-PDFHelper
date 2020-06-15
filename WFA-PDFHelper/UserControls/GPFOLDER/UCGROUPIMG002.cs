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
using System.Text.RegularExpressions;
using UtilityLib;
using System.Threading;
using WFA.PlugIn;
using Microsoft.WindowsAPICodePack.Dialogs;
using GROUPIMG;

namespace WFA.PDFHelper.UserControls
{
    public partial class UCGROUPIMG002 : UserControl
    {
        #region init
        private GROUPIMGDA GROUPIMG = new GROUPIMGDA();

        public UCGROUPIMG002()
        {
            InitializeComponent();
        }
        private void UCGROUPIMG002_Load(object sender, EventArgs e)
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
                            GROUPIMG.SelectImages(folder);
                        }
                    }

                    listboxFolder.Items.Clear();
                    string strShowList = string.Empty;

                    for (int i = 0; i < GROUPIMG.DTO.Model.GROUPMultiIMGModels.Count(); i++)
                    {
                        var models = GROUPIMG.DTO.Model.GROUPMultiIMGModels[i].SUB_GROUPIMGModels.GroupBy(t => new { t.SUB_FOLDER })
                                      .Select(group => new { SUB_FOLDER = group.Key, ARR = group.ToArray() })
                                      .ToList();
                        for(int x = 0; x < models.Count; x++)
                        {
                            for (int y = 0; y < models[x].ARR.Count(); y++)
                            {
                                foreach(var arr in models[x].ARR[y].ARRAY_FOLDER)
                                {
                                    if (models[x].ARR[y].ARRAY_FOLDER.Last() != arr)
                                    {
                                        strShowList += arr + "=>";
                                    }
                                    else
                                    {
                                        strShowList += arr+"=>"+ models[x].ARR[y].FOLDER;
                                    }
                                }
                                listboxFolder.Items.Add(GROUPIMG.DTO.Model.GROUPMultiIMGModels[i].FOLDER
                                                                          + " > " + strShowList);
                                strShowList = string.Empty;
                            }
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
                message.MESSAGE = "Can't group image.\r\nDescription: " + ex.Message;
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
            if(listboxFolder.SelectedItems.Count > 0)
            {
                foreach (var file in listboxFolder.SelectedItems)
                {
                    var spl = file.ToString().Split(new string[] { " > ", "=>" }, StringSplitOptions.None);
                    var LootFolder = GROUPIMG.DTO.Model.GROUPMultiIMGModels.Where(l => l.FOLDER == spl.First()).FirstOrDefault();
                    var SubFolder = LootFolder.SUB_GROUPIMGModels.Where(w => w.FOLDER == spl.Last()).ToList();

                    foreach(var remove in SubFolder)
                    {
                        LootFolder.SUB_GROUPIMGModels.Remove(remove);
                    }

                    GROUPIMG.DTO.Model.GROUPMultiIMGModels.MergeObject(LootFolder);

                    if (LootFolder.SUB_GROUPIMGModels.Count() == 0)
                        GROUPIMG.DTO.Model.GROUPMultiIMGModels.Remove(LootFolder);
                }
            }

            listboxFolder.Items.Clear();
            string strShowList = string.Empty;

            for (int i = 0; i < GROUPIMG.DTO.Model.GROUPMultiIMGModels.Count(); i++)
            {
                var models = GROUPIMG.DTO.Model.GROUPMultiIMGModels[i].SUB_GROUPIMGModels.GroupBy(t => new { t.SUB_FOLDER })
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
                                strShowList += arr + "=>" + models[x].ARR[y].FOLDER;
                            }
                        }
                        listboxFolder.Items.Add(GROUPIMG.DTO.Model.GROUPMultiIMGModels[i].FOLDER
                                                                  + " > " + strShowList);
                        strShowList = string.Empty;
                    }
                }

            }

            if (listboxFolder.Items.Count == 0)
                btnDelete.Visible = false;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();
            var dto = new GROUPIMGDA();

            dto = GROUPIMG;
            try
            {
                dto.DTO.Model.GenerateType = GROUPIMGGenerateType.UCGROUPIMG002;
                dto.Generate(GROUPIMG.DTO);
                lblGenerateStatus.Text = "Move Complete!";
            }
            catch (Exception ex)
            {
                var message = new MassageBoxModel();
                message.TITLE = "Error";
                message.MESSAGE = "Please re-check to Generate group image.\r\nDescription: " + ex.Message;
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
        private void ClearFolderError()
        {
            //var err = IMG2PDF.DTO.Model.IMG2FOLDERModels.Where(w => w.SUB_IMG2FOLDERModels.IsNullOrEmpty()).FirstOrDefault();
            //IMG2PDF.DTO.Model.IMG2FOLDERModels.Remove(err);
        }
        #endregion
    }
}
