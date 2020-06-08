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
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.Multiselect = true;
                dialog.IsFolderPicker = true;
                dialog.DefaultDirectory = SessionHelper.XML_FOLDER_INPUT;

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                   foreach(string folder in dialog.FileNames)
                    {
                        IMG2PDF.SelectFolder(folder);
                    }
                }

                foreach(var item in IMG2PDF.DTO.Model.IMG2FOLDERModels)
                {
                    for(int i = 0; i < item.SUB_IMG2FOLDERModels.Count(); i++)
                    {
                        listboxImage.Items.Add(item.SUB_IMG2FOLDERModels[i].FILE_NAME);
                    }                    
                }

                if (listboxImage.Items.Count > 0)
                    btnDelete.Visible = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();
            //if (listboxImage.SelectedItems.Count > 0)
            //{
            //    foreach (var file in listboxImage.SelectedItems)
            //        IMG2PDF.DTO.Model.IMG2PDFModels.RemoveAll(t => t.FILE_NAME == file.ToString());
            //}

            //listboxImage.Items.Clear();
            //foreach (var model in IMG2PDF.DTO.Model.IMG2PDFModels)
            //{
            //    listboxImage.Items.Add(model.FILE_NAME);
            //}

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

            IMG2PDF.DTO.Model.SORT = SORT_TOGGLE_ON == 0 ? true : false; //fail
            dto = IMG2PDF;
            try
            {
                dto.DTO.Model.GenerateType = IMG2PDFGenerateType.UCIMG2PDFF001;
                dto.Generate(IMG2PDF.DTO);
                lblGenerateStatus.Text = "Generate Complete!";
            }
            catch
            {
                var message = new MassageBoxModel();
                message.TITLE = "Error";
                message.MESSAGE = "Please re-check to generate pdf.";
                message.BUTTON_TYPE = ButtonType.OK;

                using (MassageBox box = new MassageBox(message))
                {
                    box.ShowDialog(this);
                }
            }
        }
        #endregion

        #region method
        private void ClearGenerateStatus()
        {
            lblGenerateStatus.Text = "";
        }
        #endregion        
    }
}
