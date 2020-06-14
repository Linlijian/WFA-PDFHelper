﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GROUPIMG
{
    public class GROUPIMGModel
    {
        public bool IS_MATCH { get; set; }
        public int COUNT_LAST { get; set; }

        public string[] REGEX_CASE { get; set; }
        public string[] ARRAY_FILE { get; set; }

        public string ErrorMassage { get; set; }
        public string GenerateType { get; set; }
        public string DirectoryFrom { get; set; }
        public string DirectoryTo { get; set; }
        public string Directory { get; set; }

        public List<GROUPIMGModels> GROUPIMGModels { get; set; }
        public List<GROUPMultiIMGModels> GROUPMultiIMGModels { get; set; }

        public Regex Regex { get; set; }
        public Match Match { get; set; }
    }

    public class GROUPIMGModels
    {
        public string IMAGE { get; set; }
        public string FOLDER { get; set; }
        public string PATH_IMAGE { get; set; }
        public string OLD_PATH { get; set; }
    }

    public class GROUPMultiIMGModels
    {
        public string FOLDER { get; set; }
        public string PATH_FOLDER { get; set; }
        public string FOLDER_OLD_PATH { get; set; }

        public List<string> TMP_ARRAY { get; set; }
        public List<SUB_GROUPIMGModels> SUB_GROUPIMGModels { get; set; }
    }

    public class SUB_GROUPIMGModels
    {
        public string IMAGE { get; set; }
        public string FOLDER { get; set; } //โฟลเดอร์ที่มึงจะไป
        public string SUB_FOLDER { get; set; } //โฟลเดอร์ที่มึงอยู่
        public string PATH_IMAGE { get; set; }
        public string SUB_FOLDER_OLD_PATH { get; set; }

        public List<string> ARRAY_FOLDER { get; set; }
    }
}
