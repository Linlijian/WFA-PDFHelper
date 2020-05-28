using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using UtilityLib;
using System.IO;

namespace IMG2PDF
{
    public class IMG2PDFDA
    {
        /// <summary>
        ///     Property to return in prop class IMG2PDFDA
        ///     
        public IMG2PDFDTO DTO { get; set; }

        /// <summary>
        ///    constructor
        ///    
        public IMG2PDFDA()
        {
            DTO = new IMG2PDFDTO();
        }

        #region img 2 pdf
        public IMG2PDFDTO GeneratePdf(IMG2PDFDTO dto)
        {
            var doc = new Document();
            string path_pdf = GenerateFileName();
            doc.SetMargins(dto.Model.Margin, dto.Model.Margin, dto.Model.Margin, dto.Model.Margin);
            dto.Model.PageSize = PageSize.A4;


            using (var stream = new FileStream(path_pdf, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(doc, stream);

                doc.Open();

                foreach (var imagePath in dto.Model.IMG2PDFModels)
                {
                    using (var imageStream = new FileStream(imagePath.FILE_PATH, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        var image = Image.GetInstance(imageStream);

                        #region Checks orientation

                        doc.SetPageSize(image.Width > image.Height
                                  ? dto.Model.PageSize.Rotate()
                                  : dto.Model.PageSize);

                        #endregion Checks orientation

                        doc.NewPage();

                        #region Configures image

                        image.ScaleToFit(new Rectangle(0, 0, doc.PageSize.Width - (doc.RightMargin + doc.LeftMargin + 1), doc.PageSize.Height - (doc.BottomMargin + doc.TopMargin + 1)));
                        image.Alignment = Image.ALIGN_CENTER;

                        #endregion Configures image

                        #region Creates elements

                        var table = new PdfPTable(1)
                        {
                            WidthPercentage = 100
                        };

                        var cell = new PdfPCell
                        {
                            VerticalAlignment = Element.ALIGN_MIDDLE,
                            MinimumHeight = doc.PageSize.Height - (doc.BottomMargin + doc.TopMargin),
                            Border = 0,
                            BorderWidth = 0,
                            Padding = 0,
                            Indent = 0
                        };

                        cell.AddElement(image);

                        table.AddCell(cell);

                        #endregion Creates elements

                        doc.Add(table);
                    }
                }

                doc.Close();
            }
            return dto;
        }
        private string GenerateFileName()
        {
            return SessionHelper.XML_FOLDER_OUTPUT + "\\" + DateTime.Now.ToString("yyy-MM-dd-hh-mm-ss") + ".pdf";
        }
        #endregion

        #region img 2 pdf folder
        #endregion

        #region img 2 pdf multi folder
        #endregion
    }
}
