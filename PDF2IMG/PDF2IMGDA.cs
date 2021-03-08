using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using UtilityLib;
using System.IO;
using System.Text.RegularExpressions;
using O2S.Components.PDFRender4NET;
using System.Drawing;

namespace PDF2IMG
{
    public class PDF2IMGDA
    {
        /// <summary>
        ///     Property to return in prop class PDF2IMGDA
        ///     
        public PDF2IMGDTO DTO { get; set; }

        /// <summary>
        ///    constructor
        ///    
        public PDF2IMGDA()
        {
            DTO = new PDF2IMGDTO();
        }
        public PDF2IMGDTO Generate(PDF2IMGDTO dto)
        {
            switch (dto.Model.GenerateType)
            {
                case PDF2IMGGenerateType.UCPDF2IMGF001: return GeneratePdf2Image(dto);
            }
            return dto;
        }
      

        #region pdf 2 img
        public PDF2IMGDTO GeneratePdf2Image(PDF2IMGDTO dto)
        {
            foreach(var model in dto.Models)
            {
                PDFFile pdfFile = PDFFile.Open(model.FILE_PATH);

                var img_path = SessionHelper.XML_FOLDER_OUTPUT + "\\" + Path.GetFileNameWithoutExtension(model.FILE_NAME);
                if (!Directory.Exists(img_path))
                {
                    Directory.CreateDirectory(img_path);
                }

                int startPageNum = 1;
                int endPageNum = pdfFile.PageCount;

                // start to convert each page
                for (int i = startPageNum; i <= endPageNum; i++)
                {
                    Bitmap pageImage = pdfFile.GetPageImage(i - 1, 56 * (int)model.Definition);
                    pageImage.Save(img_path + '\\' + i.ToString() + "." + model.IMAGE_FORMAT.ToString(), model.IMAGE_FORMAT);
                    pageImage.Dispose();
                }

                pdfFile.Dispose();
            }            

            return dto;
        }
        #endregion

        #region add on
        
        #endregion
    }
}
