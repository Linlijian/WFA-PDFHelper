using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
    public class GlobalDTO
    {
        private List<Results> dtoResults = new List<Results>();

        public List<Results> Results
        {
            get { return dtoResults; }
            set { dtoResults = value; }
        }
    }

    public class Results
    {
        [DisplayName("Folder")]
        public string FOLDER { get; set; }
        [DisplayName("Code")]
        public string CODE { get; set; }
    }
}
