using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                case GROUPIMGGenerateType.xxx: return IM2PCaseSort(dto);
            }
            return dto;
        }

        public GROUPIMGDTO IM2PCaseSort(GROUPIMGDTO dto)
        {            
            return dto;
        }
    }
}
