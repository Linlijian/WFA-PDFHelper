using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMG2PDF
{
    public class IMG2PDFModel
    {
        public int Margin { get; set; }
        public bool SORT { get; set; }
        public string ErrorMassage { get; set; }
        public string GenerateType { get; set; }
        public List<IMG2PDFModels> IMG2PDFModels { get; set; }

        public Rectangle PageSize { get; set; }
    }

    public class IMG2PDFModels
    {
        public string FILE_NAME { get; set; }
        public string FILE_PATH { get; set; }
    }
}
