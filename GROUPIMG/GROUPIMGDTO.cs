using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace GROUPIMG
{
    public class GROUPIMGDTO : GlobalDTO
    {
        public GROUPIMGDTO()
        {
            Model = new GROUPIMGModel();
            Model.GROUPIMGModels = new List<GROUPIMGModels>();
            Model.GROUPMultiIMGModels = new List<GROUPMultiIMGModels>();
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

        /// <summary>
        /// Multi move
        /// </summary>
        public const string UCGROUPIMG002 = "UCGROUPIMG002";

        /// <summary>
        /// Single old move
        /// </summary>
        public const string UC001SingleOldMove = "UC001SingleOldMove";

        /// <summary>
        /// Multi old move
        /// </summary>
        public const string UC002MultiOldMove = "UC002MultiOldMove";

    }
}
