using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace PDF2IMG
{
    public class PDF2IMGDTO : GlobalDTO
    {
        /// <summary>
        ///    constructor
        /// <summary>
        public PDF2IMGDTO()
        {
            Model = new PDF2IMGModel();
            Models = new List<PDF2IMGModel>();
        }

        /// <summary>
        ///    Property in PDF2IMGDTO
        /// <summary>
        public PDF2IMGModel Model { get; set; }
        public List<PDF2IMGModel> Models { get; set; }
    }

    public class PDF2IMGGenerateType
    {
        /// <summary>
        /// pdf to img
        /// </summary>
        public const string UCPDF2IMGF001 = "UCPDF2IMGF001";
       
    }
}
