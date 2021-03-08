using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace PDF2IMG
{
    public class PDF2IMGModel
    {
        public int Margin { get; set; }
        public int COUNT_LAST { get; set; }
        public int FOLDER_COUNT { get; set; }

        public bool SORT { get; set; }
        public bool IS_MATCH { get; set; }

        public string ErrorMassage { get; set; }
        public string GenerateType { get; set; }

        public string[] REGEX_CASE { get; set; }
        public string[] ARRAY_FILE { get; set; }

        public string FILE_PATH { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE { get; set; }
        public ImageFormat IMAGE_FORMAT { get; set; }
        public Definition Definition { get; set; }
    }   
}
