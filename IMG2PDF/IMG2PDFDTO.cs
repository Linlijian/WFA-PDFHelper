using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMG2PDF
{
    public class IMG2PDFDTO
    {
        /// <summary>
        ///    constructor
        /// <summary>
        public IMG2PDFDTO()
        {
            Model = new IMG2PDFModel();
            Models = new List<IMG2PDFModel>();
            Model.IMG2PDFModels = new List<IMG2PDFModels>();
        }

        /// <summary>
        ///    Property in IMG2PDFDTO
        /// <summary>
        public IMG2PDFModel Model { get; set; }
        public List<IMG2PDFModel> Models { get; set; }
    }

    public class IMG2PDFGenerateType
    {
        public const string UCIMG2PDFF001 = "UCIMG2PDFF001";
        public const string UCIMG2PDFF002 = "UCIMG2PDFF002";
        public const string UCIMG2PDFF003 = "UCIMG2PDFF003";
    }
}
