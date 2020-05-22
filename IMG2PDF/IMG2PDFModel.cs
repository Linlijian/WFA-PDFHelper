using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMG2PDF
{
    public class IMG2PDFModel
    {

        public List<IMG2PDFModels> IMG2PDFModels { get; set; }
    }

    public class IMG2PDFModels
    {
        public string FILE_NAME { get; set; }
        public string FILE_PATH { get; set; }
    }
}
