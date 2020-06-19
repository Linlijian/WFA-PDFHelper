using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UtilityLib;

namespace IMG2PDF
{
    public static class Sorting
    {
        /// <summary>
        /// Sort image name for Image to PDF
        /// </summary>
        /// <param name="obj">This DTO to sort image</param>
        /// <returns>New DTO</returns>
        public static List<IMG2PDFModels> IMG2PDFSort(this IMG2PDFDTO obj)
        {
            var dto = new IMG2PDFDTO();
            string[] arr = new string[obj.Model.IMG2PDFModels.Count()];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = obj.Model.IMG2PDFModels[i].FILE_NAME;
            }

            //string path = GetPath(obj.Model.IMG2PDFModels[0].FILE_PATH);
            var list = NaturalSort(arr);

            foreach (var newList in list)
            {
                //var _fullpath = path + newList;
                var temp = obj.Model.IMG2PDFModels.Where(s => s.FILE_NAME == newList).ToList();
                dto.Model.IMG2PDFModels.Add(new IMG2PDFModels { FILE_NAME = temp[0].FILE_NAME, FILE_PATH = temp[0].FILE_PATH });
            }

            return dto.Model.IMG2PDFModels;
        }

        /// <summary>
        /// Sort image name for Image to Folder
        /// </summary>
        /// <param name="obj">This DTO to sort image</param>
        /// <returns>New DTO</returns>
        public static List<IMG2FOLDERModels> IMG2FSort(this IMG2PDFDTO obj)
        {
            var dto = new IMG2PDFDTO();
            int objCount = obj.Model.IMG2FOLDERModels.Count;
            for (int i = 0; i < objCount; i++)
            {
                string []arr = new string[obj.Model.IMG2FOLDERModels[i].SUB_IMG2FOLDERModels.Count()];
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = obj.Model.IMG2FOLDERModels[i].SUB_IMG2FOLDERModels[j].FILE_NAME;
                }

                var list = NaturalSort(arr);

                dto.Model.IMG2FOLDERModels.Add(new IMG2FOLDERModels
                {
                    FOLDER_NAME = obj.Model.IMG2FOLDERModels[i].FOLDER_NAME,
                    FOLDER_PATH = obj.Model.IMG2FOLDERModels[i].FOLDER_PATH,
                    SUB_IMG2FOLDERModels = new List<SUB_IMG2FOLDERModels>()
                });

                foreach (var newList in list)
                {
                    var temp = obj.Model.IMG2FOLDERModels[i].SUB_IMG2FOLDERModels.Where(s => s.FILE_NAME == newList).ToList();
                    dto.Model.IMG2FOLDERModels[i].SUB_IMG2FOLDERModels.Add(new SUB_IMG2FOLDERModels
                    {
                        FILE_NAME = temp[0].FILE_NAME,
                        FILE_PATH = temp[0].FILE_PATH,
                        SUB_FOLDER_NAME = temp[0].SUB_FOLDER_NAME
                    });
                }

            }

            return dto.Model.IMG2FOLDERModels;
        }
        public static List<IMG2FOLDERModels> IMG2MSort(this IMG2PDFDTO obj)
        {
            var dto = new IMG2PDFDTO();
            int objCount = obj.Model.IMG2FOLDERModels.Count;
            for (int i = 0; i < objCount; i++)
            {
                string[] arr = new string[obj.Model.IMG2FOLDERModels[i].SUB_IMG2FOLDERModels.Count()];
                var models = obj.Model.IMG2FOLDERModels[i].SUB_IMG2FOLDERModels.GroupBy(t => new { t.SUB_FOLDER_NAME })
                             .Select(group => new { SUB_FOLDER = group.Key, ARR = group.ToArray() })
                             .ToList();

                dto.Model.IMG2FOLDERModels.Add(new IMG2FOLDERModels
                {
                    FOLDER_NAME = obj.Model.IMG2FOLDERModels[i].FOLDER_NAME,
                    FOLDER_PATH = obj.Model.IMG2FOLDERModels[i].FOLDER_PATH,
                    SUB_IMG2FOLDERModels = new List<SUB_IMG2FOLDERModels>()
                });

                foreach (var item in models)
                {
                    string[] arr2 = new string[item.ARR.Count()];
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        arr2[j] = item.ARR[j].FILE_NAME;
                    }

                    var lists = NaturalSort(arr2);

                    foreach (var newList in lists)
                    {
                        var temp = obj.Model.IMG2FOLDERModels[i].SUB_IMG2FOLDERModels.Where(s => s.FILE_NAME == newList).ToList();
                        dto.Model.IMG2FOLDERModels[i].SUB_IMG2FOLDERModels.Add(new SUB_IMG2FOLDERModels
                        {
                            FILE_NAME = temp[0].FILE_NAME,
                            FILE_PATH = temp[0].FILE_PATH,
                            SUB_FOLDER_NAME = temp[0].SUB_FOLDER_NAME
                        });
                    }


                }
                
            }

            return dto.Model.IMG2FOLDERModels;
        }
        private static string GetPath(string _path)
        {
            string[] path = _path.Split('\\');
            string fullPath = string.Empty;
            foreach (var p in path)
            {
                if (!p.Equals(path.Last()))
                    fullPath += p + '\\';
            }

            return fullPath;
        }
        public static IEnumerable<string> NaturalSort(IEnumerable<string> list)
        {
            int maxLen = list.Select(s => s.Length).Max();
            Func<string, char> PaddingChar = s => char.IsDigit(s[0]) ? ' ' : char.MaxValue;

            return list
                    .Select(s =>
                        new
                        {
                            OrgStr = s,
                            SortStr = Regex.Replace(s, @"(\d+)|(\D+)", m => m.Value.PadLeft(maxLen, PaddingChar(m.Value)))
                        })
                    .OrderBy(x => x.SortStr)
                    .Select(x => x.OrgStr);
        }
    }
}
