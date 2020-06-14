using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UtilityLib;

namespace GROUPIMG
{
    public class GROUPIMGDA
    {
        public GROUPIMGDTO DTO { get; set; }

        public GROUPIMGDA()
        {
            DTO = new GROUPIMGDTO();
        }
        public GROUPIMGDTO Generate(GROUPIMGDTO dto)
        {
            switch (dto.Model.GenerateType)
            {
                case GROUPIMGGenerateType.UCGROUPIMG001: return SigleMove(dto);
            }
            return dto;
        }

        public GROUPIMGDTO SigleMove(GROUPIMGDTO dto)
        {
            string MoveForm = SessionHelper.XML_FOLDER_OUTPUT;
            foreach (var item in dto.Model.GROUPIMGModels)
            {
                dto.Model.DirectoryFrom = item.PATH_IMAGE;
                dto.Model.DirectoryTo = MoveForm + '\\' + item.FOLDER + '\\' + item.IMAGE;
                dto.Model.Directory = MoveForm + '\\' + item.FOLDER;

                if (!Directory.Exists(dto.Model.Directory))
                {
                    Directory.CreateDirectory(dto.Model.Directory);
                    File.Move(dto.Model.DirectoryFrom, dto.Model.DirectoryTo);
                }
                else
                {
                    File.Move(dto.Model.DirectoryFrom, dto.Model.DirectoryTo);
                }
            }

                return dto;
        }
        public void SelectImage(string directory, string searchPatterns = "*.jpg")
        {
            string sourceDirectory = directory;
            try
            {
                var allFiles = Directory.EnumerateFiles(sourceDirectory, searchPatterns, SearchOption.AllDirectories);
                DTO.Model.REGEX_CASE = SessionHelper.XML_CASE_SELECT.Split(new string[] { "0x1010" }, StringSplitOptions.None);

                foreach (string currentFile in allFiles)
                {
                    if(DTO.Model.GROUPIMGModels.Where(m=>m.PATH_IMAGE == currentFile).Count() == 0)
                    {
                        string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                        DTO.Model.ARRAY_FILE = fileName.Split('\\');

                        if (DTO.Model.ARRAY_FILE.Count() == 1)
                        {
                            GenerateFolder(fileName, currentFile, directory);
                        }
                    }                    
                }
            }
            catch (Exception e)
            {

            }
        }
        private void GenerateFolder(string fileName, string currentFile, string oldPath)
        {
            DTO.Model.IS_MATCH = true;
            foreach (string rgCase in DTO.Model.REGEX_CASE)
            {
                DTO.Model.Regex = new Regex(rgCase);
                DTO.Model.Match = DTO.Model.Regex.Match(fileName);
                if (DTO.Model.Match.Success)
                {
                    var model = new GROUPIMGModels
                    {
                        IMAGE = fileName,
                        FOLDER = GenerateFolderName(DTO.Model.Match.Value),
                        OLD_PATH = oldPath,
                        PATH_IMAGE = currentFile
                    };
                    DTO.Model.GROUPIMGModels.Add(model);

                    //DTO.Model.Match.Value = __Monday_Tights_
                    //else ขึ้นต้นเเละลงท้ายด้วยตัวอัพษรหรือตัวเลขเท่านั้น = [a-zA-Z\d]_?[a-zA-Z\d_.-]+([a-zA-Z\d])
                    //currentFile = E:\Ebook\R18\ImageAllHentaiV2\temp\2017-06-01\Doujin-TH.com__Monday_Tights__0001.jpg

                    return;
                }
            }

            //if all case select
            if (DTO.Model.IS_MATCH)
            {
                var model = new GROUPIMGModels
                {
                    IMAGE = fileName,
                    FOLDER = "AllSelect",
                    OLD_PATH = currentFile,
                    PATH_IMAGE = currentFile + "AllSelect"
                };
                DTO.Model.GROUPIMGModels.Add(model);
            }
        }
        #region add-in
        private string GenerateFolderName(string folder)
        {
            try
            {
                DTO.Model.Regex = new Regex(@"[a-zA-Z\d]_?[a-zA-Z\d_.-]+([a-zA-Z\d])");
                DTO.Model.Match = DTO.Model.Regex.Match(folder);
                if (DTO.Model.Match.Success)
                {
                    return DTO.Model.Match.Value;
                }
                else
                {
                    return folder;
                }
            }
            catch { return folder; }
        }
        #endregion
    }
}
