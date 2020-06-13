using System;
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

        public string[] REGEX_CASE { get; set; }
        public string[] ARRAY_FILE { get; set; }

        public string ErrorMassage { get; set; }
        public string GenerateType { get; set; }

        public List<GROUPIMGModels> GROUPIMGModels { get; set; }

        public Regex Regex { get; set; }
    }

    public class GROUPIMGModels
    {
        public string IMAGE { get; set; }
        public string PATH_FOLDER { get; set; }
        public string PATH_IMAGE { get; set; }
    }
}
