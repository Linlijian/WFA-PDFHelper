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
using System.Threading;
using WFA.PlugIn;
using UtilityLib;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WFA.PDFHelper.UserControls
{
    public partial class UCSETTINGF001 : UserControl
    {
        Point pt;
        public UCSETTINGF001()
        {
            InitializeComponent();
            Button b = new Button();
            b.Location = new Point(0, 1350);
            b.Text = "test";
            this.innerPanel.Controls.Add(b);
            pt = new Point(this.innerPanel.AutoScrollPosition.X, this.innerPanel.AutoScrollPosition.Y);
            this.customScrollbar1.Minimum = 0;
            this.customScrollbar1.Maximum = this.innerPanel.DisplayRectangle.Height;

            this.customScrollbar1.LargeChange = customScrollbar1.Maximum / customScrollbar1.Height + this.innerPanel.Height;
            this.customScrollbar1.SmallChange = 15;
            this.customScrollbar1.Value = Math.Abs(this.innerPanel.AutoScrollPosition.Y);
            outerPanel.Width -= 20;
            customScrollbar1.Left -= 20;
        }
        private void UCSETTINGF001_Load(object sender, EventArgs e)
        {
            lblShowInput.Text = SessionHelper.XML_FOLDER_INPUT;
        }
        private void item_scroll(object sender, MouseEventArgs e)
        {

            customScrollbar1.Value = innerPanel.AutoScrollPosition.Y * -1;
            innerPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);
            customScrollbar1.Invalidate();
            Application.DoEvents();

        }
        private void Custom_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                customScrollbar1.Value = (innerPanel.AutoScrollPosition.Y + 120) * -1;
                innerPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);
                customScrollbar1.Invalidate();
                Application.DoEvents();
            }
            else
            {
                customScrollbar1.Value = (innerPanel.AutoScrollPosition.Y - 120) * -1;
                innerPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);
                customScrollbar1.Invalidate();
                Application.DoEvents();
            }

        }
        private void customScrollbar1_Scroll(object sender, EventArgs e)
        {
            try
            {

                innerPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);
                Console.WriteLine("custom: " + customScrollbar1.Value.ToString());
                customScrollbar1.Invalidate();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAddInputPath_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.InitialDirectory = lblShowInput.Text;
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    lblShowInput.Text = dialog.FileName;
                }
            }                
        }
        private void btnAddOutputPath_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.InitialDirectory = lblShowInput.Text;
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                   
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //save xml
            var xml = new XMLHelper();

            xml.STATE.FolderIntput = lblShowInput.Text;

            xml.writeConfig(xml.STATE);

            //load to sassion
            xml.loadConfig();
            SessionHelper.XML_FOLDER_INPUT = xml.STATE.FolderIntput;
            SessionHelper.XML_FOLDER_OUTPUT = xml.STATE.FolderOutput;
        }

        
    }
}
