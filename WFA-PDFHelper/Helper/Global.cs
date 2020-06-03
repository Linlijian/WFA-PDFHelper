using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WFA.PDFHelper.Helper
{
    class Global
    {
        #region Panel
        /// <summary>
        /// To hide PActive control.
        /// </summary>
        /// <param name="_control">panel to hine PActive</param>
        public static void PActiveHide(Control  _control)
        {
            foreach (Control panel in _control.Controls)
            {
                FindControl(panel.Controls);
            }
        }

        /// <summary>
        /// find children in control
        /// </summary>
        /// <param name="controls"></param>
        private static void FindControl(Control.ControlCollection controls)
        {
            var regex = new Regex("(PA|PSA)");
            foreach (Control control in controls)
            {
                if (control.Controls.Count > 0)
                {
                    FindControl(control.Controls);
                }
                else
                {
                    if (regex.IsMatch(control.Name))
                        control.Hide();
                }
            }
        }
        #endregion

    }
}
