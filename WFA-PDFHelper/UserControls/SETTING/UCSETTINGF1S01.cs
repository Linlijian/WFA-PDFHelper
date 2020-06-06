using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;

namespace WFA.PDFHelper.UserControls
{
    /// <summary>
    /// UCSETTINGF1S01 is sub function of  UCSETTINGF001
    /// </summary>
    public partial class UCSETTINGF1S01 : UserControl
    {
        public UCSETTINGF1S01()
        {
            InitializeComponent();
        }

        private void btnAddCustomSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomSelect_Click(object sender, EventArgs e)
        {
            if (listboxCustomSelect.SelectedItems.Count > 0)
            {
               // foreach (var file in listboxCustomSelect.SelectedItems)
                    //IMG2PDF.DTO.Model.IMG2PDFModels.RemoveAll(t => t.FILE_NAME == file.ToString());
            }

            listboxCustomSelect.Items.Clear();
            //foreach (var model in IMG2PDF.DTO.Model.IMG2PDFModels)
            //{
            //    listboxCustomSelect.Items.Add(model.FILE_NAME);
            //}

            if (listboxCustomSelect.Items.Count == 0)
                btnDeleteCustomSelect.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save xml
            var xml = new XMLHelper();

            xml.loadConfig();
            foreach(string item in listboxCustomSelect.Items)
            {
                if (listboxCustomSelect.Items.Count == 1)
                {
                    xml.Model.CaseSelect = item;
                }
                else
                {
                    xml.Model.CaseSelect += item + ',';
                }                    
            }

            xml.MergeConfig();
            xml.writeConfig(xml.STATE);

            //load to sassion
            SessionHelper.XML_CASE_SELECT = xml.STATE.CaseSelect;
        }

        private void UCSETTINGF1S01_Load(object sender, EventArgs e)
        {
            if (SessionHelper.XML_CASE_SELECT.IsNullOrEmpty())
                btnDeleteCustomSelect.Visible = false;

            listboxCustomSelect.Items.Add(SessionHelper.XML_CASE_SELECT);
        }
    }
}
