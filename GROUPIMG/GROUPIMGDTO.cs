using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROUPIMG
{
    public class GROUPIMGDTO
    {
        public GROUPIMGDTO()
        {
            Model = new GROUPIMGModel();
            Model.GROUPIMGModels = new List<GROUPIMGModels>();
        }

        public GROUPIMGModel Model { get; set; }
        public List<GROUPIMGModels> Models { get; set; }
    }

    public class GROUPIMGGenerateType
    {
        /// <summary>
        /// Single move
        /// </summary>
        public const string UCGROUPIMG001 = "UCGROUPIMG001";

    }
}
