using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;
using WFA.PlugIn;

namespace WFA_PlugIn
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            VerifyStartUp();
        }
        private void VerifyStartUp()
        {
            //load xml
            lblStatus.Text = "Load Config";
            var xml = new XMLHelper();
            xml.loadConfig();

            //check folder output
            lblStatus.Text = "Folder Output";
            try
            {
                if (!xml.STATE.FolderOutput.IsNullOrEmpty())
                {
                    if (!Directory.Exists(xml.STATE.FolderOutput))
                    {
                        var state = new FormState();
                        state.FolderOutput = @"C:\Generate\";
                        Directory.CreateDirectory(state.FolderOutput);

                        xml.writeConfig(xml.STATE);
                    }
                }
                else
                {
                    SessionHelper.SYS_StartUp = false;
                    SessionHelper.SYS_ERROR_CODE = "001";
                    SessionHelper.SYS_ERROR_MESSAGE = "Can't find Folder Output!";
                    SessionHelper.SYS_TITLE = "ERROR";

                    return;
                }
                
            }
            catch (Exception x)
            {
                SessionHelper.SYS_StartUp = false;
                SessionHelper.SYS_ERROR_CODE = "001";
                SessionHelper.SYS_ERROR_MESSAGE = "Can't Create Folder Output!";
                SessionHelper.SYS_TITLE = "ERROR";

                return;
            }

            xml.loadConfig();

            try
            {
                var load_data = xml;
                SessionHelper.XML_FOLDER_INPUT = load_data.STATE.FolderIntput;
                SessionHelper.XML_FOLDER_OUTPUT = load_data.STATE.FolderOutput;
            }
            catch (Exception x)
            {
                SessionHelper.SYS_StartUp = false;
                SessionHelper.SYS_ERROR_CODE = "002";
                SessionHelper.SYS_ERROR_MESSAGE = "Can't Load config in Session";
                SessionHelper.SYS_TITLE = "ERROR";

                return;
            }

            SessionHelper.SYS_StartUp = true;
        }

    }
}
