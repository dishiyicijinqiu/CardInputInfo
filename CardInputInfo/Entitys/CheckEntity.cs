using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardInputInfo.Entitys
{
    public class CheckEntity
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string Spec { get; set; }
        /// <summary>
        /// 生产批号
        /// </summary>
        public string BatchNo { get; set; }
        /// <summary>
        /// 生产数量
        /// </summary>
        public int Qty { get; set; }
        /// <summary>
        /// 测量时间
        /// </summary>
        public string TestTime { get; set; }
        /// <summary>
        /// 抽检数量
        /// </summary>
        public int CheckQty { get; set; }
        /// <summary>
        /// 测量结果
        /// </summary>
        public string TestResult { get; set; }
        /// <summary>
        /// 测量员
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string PicPath { get; set; }
        /// <summary>
        /// 保存路径
        /// </summary>
        public string ExportPath { get; set; }


        public float Width { get; set; }
        public float Height { get; set; }
    }
}
