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
using WFA.PlugIn;

namespace WFA.PDFHelper.UserControls
{
    /// <summary>
    /// UCSETTINGF1S01 is sub function of  UCSETTINGF001
    /// </summary>
    public partial class UCSETTINGF1S01 : UserControl
    {
        #region init
        public UCSETTINGF1S01()
        {
            InitializeComponent();
        }
        private void UCSETTINGF1S01_Load(object sender, EventArgs e)
        {
            if (SessionHelper.XML_CASE_SELECT.IsNullOrEmpty())
                btnDeleteCustomSelect.Visible = false;

            var list = SessionHelper.XML_CASE_SELECT.Split(new[] { "0x1010" }, StringSplitOptions.None);
            foreach (string item in list)
            {
                listboxCustomSelect.Items.Add(item);
            }            
        }
        #endregion

        #region event
        private void btnAddCustomSelect_Click(object sender, EventArgs e)
        {
            SaveToListBox();
        }
        private void btnDeleteCustomSelect_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();
            if (listboxCustomSelect.SelectedItems.Count > 0)
            {
                List<string> item = new List<string>();
                foreach (string list in listboxCustomSelect.Items)
                {
                    item.Add(list);
                }

                foreach (string list in listboxCustomSelect.SelectedItems)
                {
                    item.Remove(list);
                }

                listboxCustomSelect.Items.Clear();
                foreach (string list in item)
                {
                    listboxCustomSelect.Items.Add(list);
                }

            }

            if (listboxCustomSelect.Items.Count == 0)
                btnDeleteCustomSelect.Visible = false;
        }
        private void txtCustomSelect_KeyUp(object sender, KeyEventArgs e)
        {
            ClearGenerateStatus();
            if (e.KeyCode == Keys.Enter)
            {
                //Do something
                SaveToListBox();
                e.Handled = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ClearGenerateStatus();

            //save xml
            var xml = new XMLHelper();

            xml.loadConfig();
            foreach (string item in listboxCustomSelect.Items)
            {
                if (listboxCustomSelect.Items.Count == 1)
                {
                    xml.Model.CaseSelect = item;
                }
                else
                {
                    xml.Model.CaseSelect += item + "0x1010";
                }
            }

            if (listboxCustomSelect.Items.Count != 1)
                xml.Model.CaseSelect = RemoveLast(xml.Model.CaseSelect);

            xml.MergeConfig();
            xml.writeConfig(xml.STATE);

            if (!xml.IsComplete())
            {
                var message = new MassageBoxModel();
                message.TITLE = "Error";
                message.MESSAGE = xml.ERROR;
                message.BUTTON_TYPE = ButtonType.OK;

                using (MassageBox box = new MassageBox(message))
                {
                    box.ShowDialog(this);
                }

                lblSaveStatus.Text = xml.ERROR;

                return;
            }
            else
            {
                lblSaveStatus.Text = "Save Complete!";
            }

            //load to sassion
            SessionHelper.XML_CASE_SELECT = xml.STATE.CaseSelect;
        }
        #endregion

        #region method  
        private void ClearGenerateStatus()
        {
            lblSaveStatus.Text = "";
        }
        private void SaveToListBox()
        {
            if (txtCustomSelect.Text.IsNullOrEmpty())
                return;

            listboxCustomSelect.Items.Add(txtCustomSelect.Text);
            txtCustomSelect.Clear();
            txtCustomSelect.Focus();

            btnDeleteCustomSelect.Visible = true;
        }
        private string RemoveLast(string xml)
        {
            return xml.Substring(0, xml.Length - 1);
        }
        #endregion
    }
}
