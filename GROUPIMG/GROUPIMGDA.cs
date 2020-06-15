﻿using System;
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
                case GROUPIMGGenerateType.UCGROUPIMG002: return MultiMove(dto);
            }
            return dto;
        }

        #region SigleMove
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
                    if (DTO.Model.GROUPIMGModels.Where(m => m.PATH_IMAGE == currentFile).Count() == 0)
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

                    return;
                }
            }

            //if all case select
            if (DTO.Model.IS_MATCH)
            {
                var model = new GROUPIMGModels
                {
                    IMAGE = fileName,
                    FOLDER = GenerateFolderNameEx(currentFile),
                    OLD_PATH = currentFile,
                    PATH_IMAGE = currentFile
                };
                DTO.Model.GROUPIMGModels.Add(model);
            }
        }
        #endregion

        #region MultiMove
        public GROUPIMGDTO MultiMove(GROUPIMGDTO dto)
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
        public void SelectImages(string directory, string searchPatterns = "*.jpg")
        {
            string sourceDirectory = directory;
            try
            {
                var allFiles = Directory.EnumerateFiles(sourceDirectory, searchPatterns, SearchOption.AllDirectories);
                DTO.Model.REGEX_CASE = SessionHelper.XML_CASE_SELECT.Split(new string[] { "0x1010" }, StringSplitOptions.None);

                if (!AddFolder(directory))
                    return;

                DTO.Model.COUNT_LAST = DTO.Model.GROUPMultiIMGModels.Count() - 1;

                foreach (string currentFile in allFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    DTO.Model.ARRAY_FILE = fileName.Split('\\');


                    if (DTO.Model.ARRAY_FILE.Count() > 1)
                    {
                        GenerateFolders(fileName, currentFile, directory);
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
        private void GenerateFolders(string fileName, string currentFile, string oldPath)
        {
            List<string> TMP_ARRAY = new List<string>();
            DTO.Model.Regex = new Regex("(.*)(?=.*.JPG|.*.jpg)");

            foreach (string folder in DTO.Model.ARRAY_FILE)
            {
                DTO.Model.Match = DTO.Model.Regex.Match(folder);
                if (DTO.Model.Match.Success)
                {
                    DTO.Model.IS_MATCH = true;
                    foreach (string rgCase in DTO.Model.REGEX_CASE)
                    {
                        DTO.Model.Regex = new Regex(rgCase);
                        DTO.Model.Match = DTO.Model.Regex.Match(fileName);
                        if (DTO.Model.Match.Success)
                        {
                            var model = new SUB_GROUPIMGModels
                            {
                                IMAGE = folder,
                                FOLDER = GenerateFolderName(DTO.Model.Match.Value),
                                SUB_FOLDER = TMP_ARRAY.Last(),
                                PATH_IMAGE = currentFile,
                                SUB_FOLDER_OLD_PATH = GenerateSubFolders(folder, TMP_ARRAY)
                            };
                            DTO.Model.GROUPMultiIMGModels[DTO.Model.COUNT_LAST].SUB_GROUPIMGModels.Add(model);

                            DTO.Model.IS_MATCH = false;
                            break;
                        }
                    }

                    //if all case select
                    if (DTO.Model.IS_MATCH)
                    {
                        var model = new SUB_GROUPIMGModels
                        {
                            IMAGE = folder,
                            FOLDER = GenerateFolderNameEx(fileName),
                            SUB_FOLDER = TMP_ARRAY.Last(),
                            PATH_IMAGE = currentFile,
                            SUB_FOLDER_OLD_PATH = GenerateSubFolders(folder, TMP_ARRAY)
                        };
                        DTO.Model.GROUPMultiIMGModels[DTO.Model.COUNT_LAST].SUB_GROUPIMGModels.Add(model);                        
                    }
                }
                else
                {                    
                    TMP_ARRAY.Add(folder);
                }                
            }

            DTO.Model.GROUPMultiIMGModels[DTO.Model.COUNT_LAST].SUB_GROUPIMGModels.Last().ARRAY_FOLDER = TMP_ARRAY;
            
        }
        #endregion

        #region add-in
        private string GenerateFolderName(string folder)
        {
            try
            {
                DTO.Model.Regex = new Regex(@"[a-zA-Z\d]_?[a-zA-Z\d_.-]+([a-zA-Z\d])(?=.jpg|JPG)");
                DTO.Model.Match = DTO.Model.Regex.Match(folder);
                if (DTO.Model.Match.Success)
                {
                    return DTO.Model.Match.Value;
                }
                else
                {
                    DTO.Model.Regex = new Regex(@"[a-zA-Z\d]_?[a-zA-Z\d_.-]+([a-zA-Z\d])");
                    DTO.Model.Match = DTO.Model.Regex.Match(folder);
                    return DTO.Model.Match.Value;
                }
            }
            catch { return "AllCase"; }
        }
        private string GenerateFolderNameEx(string fileName)
        {
            try
            {
                var folder = fileName.Split('\\');
                DTO.Model.Regex = new Regex(@"[a-zA-Z\d]_?[a-zA-Z\d_.-]+([a-zA-Z\d])(?=.jpg|JPG)");
                if (folder.Count() > 2)
                {
                    return folder[folder.Count() - 2];
                }
                else
                {
                    DTO.Model.Match = DTO.Model.Regex.Match(folder.Last());
                    return DTO.Model.Match.Value;
                }
            }
            catch { return "AllCase"; }
        }
        private string GenerateSubFolders(string image, List<string> arr)
        {
            string subFolder = string.Empty;
            foreach (var sub in arr)
            {
                subFolder += sub + "\\";
            }

            return subFolder + image;
        }
        private bool AddFolder(string directory)
        {
            var dup = DTO.Model.GROUPMultiIMGModels.Where(w => w.FOLDER == directory.Split('\\').Last()).FirstOrDefault();
            if (dup.IsNullOrEmpty())
            {
                DTO.Model.GROUPMultiIMGModels.Add(new GROUPMultiIMGModels
                {
                    FOLDER = directory.Split('\\').Last(),
                    PATH_FOLDER = directory,
                    SUB_GROUPIMGModels = new List<SUB_GROUPIMGModels>(),
                    TMP_ARRAY = new List<string>()
                });

                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
