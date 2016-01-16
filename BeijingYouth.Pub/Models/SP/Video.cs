using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BeijingYouth.Pub.Models.SP
{
    public class Video
    {
        #region 基本信息

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("编号")]
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("编号")]
        public string Name { get; set; }

        #endregion
    }
    
}
