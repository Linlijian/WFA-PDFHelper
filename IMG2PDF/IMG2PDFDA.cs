using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMG2PDF
{
    public class IMG2PDFDA
    {
        //
        // Summary:
        //     Property to return in prop class IMG2PDFDA
        public IMG2PDFDTO DTO { get; set; }

        //
        // Summary:
        //    constructor
        public IMG2PDFDA()
        {
            DTO = new IMG2PDFDTO();
        }

        #region img 2 pdf
        public IMG2PDFDTO GeneratePdf(IMG2PDFDTO dto)
        {
            //ไปทำหน้า setting ก่อนเพื่อเอา path output มาใช้

            return dto;
        }
        #endregion

        #region img 2 pdf folder
        #endregion

        #region img 2 pdf multi folder
        #endregion
    }
}
