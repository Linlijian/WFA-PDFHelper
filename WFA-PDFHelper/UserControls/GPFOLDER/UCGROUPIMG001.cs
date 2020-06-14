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
    public partial class UCGROUPIMG001 : UserControl
    {
        #region init
        private GROUPIMGDA GROUPIMG = new GROUPIMGDA();

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
                    dialog.IsFolderPicker = true;
                    dialog.DefaultDirectory = SessionHelper.XML_FOLDER_INPUT;

                    if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                    {
                        foreach (string folder in dialog.FileNames)
                        {
                            GROUPIMG.SelectImage(folder);
                        }
                    }

                    listboxFolder.Items.Clear();
                    var models = GROUPIMG.DTO.Model.GROUPIMGModels.GroupBy(item => item.FOLDER)
                                .Select(group => new { folder = group.Key })
                                .ToList();

                    foreach (var item in models)
                    {
                        listboxFolder.Items.Add(item.folder);
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
            if (listboxFolder.SelectedItems.Count > 0)
            {
                foreach (var folder in listboxFolder.SelectedItems)
                    GROUPIMG.DTO.Model.GROUPIMGModels.RemoveAll(t => t.FOLDER == folder.ToString());
            }

            listboxFolder.Items.Clear();
            var models = GROUPIMG.DTO.Model.GROUPIMGModels.GroupBy(item => item.FOLDER)
                        .Select(group => new { folder = group.Key })
                        .ToList();

            foreach (var item in models)
            {
                listboxFolder.Items.Add(item.folder);
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
                dto.DTO.Model.GenerateType = GROUPIMGGenerateType.UCGROUPIMG001;
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
