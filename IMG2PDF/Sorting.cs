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
        public static List<IMG2PDFModels> IMG2PDFSort(this IMG2PDFDTO obj)
        {
            var dto = new IMG2PDFDTO();
            string[] arr = new string[obj.Model.IMG2PDFModels.Count()];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = obj.Model.IMG2PDFModels[i].FILE_NAME;
            }

            string path = GetPath(obj.Model.IMG2PDFModels[0].FILE_PATH);
            var list = NaturalSort(arr);

            foreach (var newList in list)
            {
                var _fullpath = path + newList;
                var temp = obj.Model.IMG2PDFModels.Where(s => s.FILE_PATH == _fullpath).ToList();
                dto.Model.IMG2PDFModels.Add(new IMG2PDFModels { FILE_NAME = temp[0].FILE_NAME, FILE_PATH = temp[0].FILE_PATH });
            }

            return dto.Model.IMG2PDFModels;
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
