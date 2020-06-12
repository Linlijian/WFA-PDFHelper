using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IMG2PDF
{
    public class IMG2PDFModel
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

        public List<IMG2PDFModels> IMG2PDFModels { get; set; }
        public List<IMG2FOLDERModels> IMG2FOLDERModels { get; set; }

        public Rectangle PageSize { get; set; }
        public Match Match { get; set; }
        public Regex Regex { get; set; }
    }

    public class IMG2PDFModels
    {
        public string FILE_NAME { get; set; }
        public string FILE_PATH { get; set; }
    }

    public class IMG2FOLDERModels
    {
        public string FOLDER_NAME { get; set; }
        public string FOLDER_PATH { get; set; }
        public List<SUB_IMG2FOLDERModels> SUB_IMG2FOLDERModels { get; set; }
    }

    public class SUB_IMG2FOLDERModels
    {
        public string FILE_NAME { get; set; }
        public string FILE_PATH { get; set; }
        public string SUB_FOLDER_NAME { get; set; }
    }
}
