using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.PDFHelper.Helper
{
    static class ButtonHelper
    {
        public static void SetMouseHover(this object _button, Color _OverBackColor, Color _DownBackColor)
        {
            Button btn = (Button)_button;
            btn.FlatAppearance.MouseOverBackColor = _OverBackColor;
            btn.FlatAppearance.MouseDownBackColor = _DownBackColor;
        }
        public static void SetOverBackColor(this object _button, Color _OverBackColor)
        {
            Button btn = (Button)_button;
            btn.FlatAppearance.MouseOverBackColor = _OverBackColor;
        }
        public static void SetDownBackColor(this object _button, Color _DownBackColor)
        {
            Button btn = (Button)_button;
            btn.FlatAppearance.MouseDownBackColor = _DownBackColor;
        }
    }
}
