using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMG2PDF
{
    public class IMG2PDFDTO
    {
        //
        // Summary:
        //    constructor
        public IMG2PDFDTO()
        {
            Model = new IMG2PDFModel();
            Models = new List<IMG2PDFModel>();
            Model.IMG2PDFModels = new List<IMG2PDFModels>();
        }

        //
        // Summary:
        //    Property in IMG2PDFDTO
        public IMG2PDFModel Model { get; set; }
        public List<IMG2PDFModel> Models { get; set; }
    }
}
