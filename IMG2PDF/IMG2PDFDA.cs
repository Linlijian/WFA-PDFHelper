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
        public IMG2PDFDTO Generate(IMG2PDFDTO dto)
        {
            switch (dto.Model.GenerateType)
            {
                case IMG2PDFGenerateType.UCIMG2PDFF001: return IM2PCaseSort(dto);
                case IMG2PDFGenerateType.UCIMG2PDFF002: return IM2FCaseSort(dto);
            }
            return dto;
        }

        #region img 2 pdf
        public IMG2PDFDTO IM2PCaseSort(IMG2PDFDTO dto)
        {
            if (dto.Model.SORT)
                dto.Model.IMG2PDFModels = dto.IMG2PDFSort();

            GenerateImage2Pdf(dto);
            return dto;
        }
        public IMG2PDFDTO GenerateImage2Pdf(IMG2PDFDTO dto)
        {
            var doc = new Document();
            string path_pdf = GenerateFileName();
            doc.SetMargins(dto.Model.Margin, dto.Model.Margin, dto.Model.Margin, dto.Model.Margin);

            using (var stream = new FileStream(path_pdf, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(doc, stream);

                doc.Open();

                foreach (var imagePath in dto.Model.IMG2PDFModels)
                {
                    CreatePDF(imagePath.FILE_PATH, doc, PageSize.A4);
                }

                doc.Close();
            }
            return dto;
        }
        #endregion

        #region img 2 pdf folder
        public IMG2PDFDTO IM2FCaseSort(IMG2PDFDTO dto)
        {
            if (dto.Model.SORT)
                dto.Model.IMG2FOLDERModels = dto.IMG2FSort();

            GenerateImage2Folder(dto);
            return dto;
        }
        public IMG2PDFDTO GenerateImage2Folder(IMG2PDFDTO dto)
        {
            int folderCount = dto.Model.IMG2FOLDERModels.Count();
            for (int i = 0; i < folderCount; i++)
            {
                var folder = dto.Model.IMG2FOLDERModels[i];
                string path_pdf = GenerateFileName(folder.FOLDER_NAME);

                var doc = new Document();
                doc.SetMargins(dto.Model.Margin, dto.Model.Margin, dto.Model.Margin, dto.Model.Margin);
                dto.Model.PageSize = PageSize.A4;

                using (var stream = new FileStream(path_pdf, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfWriter.GetInstance(doc, stream);

                    doc.Open();

                    foreach (var imagePath in folder.SUB_IMG2FOLDERModels)
                    {
                        CreatePDF(imagePath.FILE_PATH, doc, PageSize.A4);
                    }

                    doc.Close();
                }
            }

            return dto;
        }
        public void SelectFolder(string directory, string searchPatterns = "*.jpg")
        {
            string sourceDirectory = directory;
            try
            {
                var allFiles = Directory.EnumerateFiles(sourceDirectory, searchPatterns, SearchOption.AllDirectories);
                DTO.Model.REGEX_CASE = SessionHelper.XML_CASE_SELECT.Split(new string[] { "0x1010" }, StringSplitOptions.None);

                if (!AddFolder(directory))
                    return;

                DTO.Model.COUNT_LAST = DTO.Model.IMG2FOLDERModels.Count() - 1;

                foreach (string currentFile in allFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    DTO.Model.ARRAY_FILE = fileName.Split('\\');

                    if (DTO.Model.ARRAY_FILE.Count() == 1)
                    {
                        SelectFile(fileName, currentFile);
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
        #endregion

        #region img 2 pdf multi folder
        #endregion

        #region add on
        private void CreatePDF(string imagePath, Document doc, Rectangle PageSize)
        {
            using (var imageStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var image = Image.GetInstance(imageStream);

                #region Checks orientation

                doc.SetPageSize(image.Width > image.Height
                          ? PageSize.Rotate()
                          : PageSize);

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
        private void SelectFile(string fileName, string currentFile)
        {
            foreach (string rgCase in DTO.Model.REGEX_CASE)
            {
                DTO.Model.Regex = new Regex(rgCase);
                DTO.Model.Match = DTO.Model.Regex.Match(fileName);
                if (DTO.Model.Match.Success)
                {
                    DTO.SubModel = new SUB_IMG2FOLDERModels
                    {
                        FILE_NAME = fileName,
                        FILE_PATH = currentFile,
                        SUB_FOLDER_NAME = "" //if multi
                    };
                    DTO.Model.IS_MATCH = false;

                    break;
                }
            }

            //if all case select
            if (!DTO.Model.IS_MATCH)
            {
                DTO.SubModel = new SUB_IMG2FOLDERModels
                {
                    FILE_NAME = fileName,
                    FILE_PATH = currentFile,
                    SUB_FOLDER_NAME = "" //if multi
                };
                DTO.Model.IS_MATCH = false;
            }

            //add in list
            if (!DTO.Model.IMG2FOLDERModels[DTO.Model.COUNT_LAST].SUB_IMG2FOLDERModels.IsNullOrEmpty())
            {
                DTO.Model.IMG2FOLDERModels[DTO.Model.COUNT_LAST].SUB_IMG2FOLDERModels.Add(DTO.SubModel);
            }
            else
            {
                DTO.Model.IMG2FOLDERModels[DTO.Model.COUNT_LAST].SUB_IMG2FOLDERModels = DTO.SubModel.ToList();
            }

        }
        private bool AddFolder(string directory)
        {
            var dup = DTO.Model.IMG2FOLDERModels.Where(w => w.FOLDER_NAME == directory.Split('\\').Last()).FirstOrDefault();
            if (dup.IsNullOrEmpty())
            {
                DTO.Model.IMG2FOLDERModels.Add(new IMG2FOLDERModels
                {
                    FOLDER_NAME = directory.Split('\\').Last(),
                    FOLDER_PATH = directory
                });

                return true;
            }
            else
            {
                return false;
            }
        }
        private string GenerateFileName()
        {
            return SessionHelper.XML_FOLDER_OUTPUT + "\\" + DateTime.Now.ToString("yyy-MM-dd-hh-mm-ss") + ".pdf";
        }
        private string GenerateFileName(string folder)
        {
            return SessionHelper.XML_FOLDER_OUTPUT + "\\" + folder + ".pdf";
        }

        private bool IsDup(string fileName)
        {
            //var dup = DTO.Model.IMG2FOLDERModels.Where(
            //     t => t.SUB_IMG2FOLDERModels.Where(w=>w.FILE_NAME== fileName) == t
            //     ).FirstOrDefault();
            //var a = (from model in DTO.Model.IMG2FOLDERModels
            //         where model.SUB_IMG2FOLDERModels.Where(w => w.FILE_NAME == fileName).FirstOrDefault() == null
            //         select model.FOLDER_NAME).ToString();

            foreach(var model in DTO.Model.IMG2FOLDERModels)
            {
                var dup2 = model.SUB_IMG2FOLDERModels.Where(w => w.FILE_NAME == fileName).FirstOrDefault();
                if (dup2.IsNullOrEmpty())
                {
                    return false;
                }
                else
                {
                    break;
                }
                    
            }

            return true;
            //return dup.IsNullOrEmpty() ? false : true;
        }
        public IMG2PDFDTO test(IMG2PDFDTO dto)
        {
            //WORK
            dto.Model.IMG2PDFModels = dto.IMG2PDFSort();

            //SelectFolder
            //Regex regex;// = new Regex(@"\d{6,8}_");
            //Match match;
            //if match (_)(.*)[a-zA-Z][-._](\d{1,2})
            //do something eg. __Aneman_10
            //else
            //do (_)(.*)[a-zA-Z](_) eg. __Mane_Seku_
            //else regex/case  select = null them select all image in folder

            return dto;
        }
        #endregion
    }
}
