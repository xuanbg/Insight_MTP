using System.Collections.Generic;
using Insight.Base.BaseForm.Entities;

namespace Insight.MTP.Client.Common.Entity
{
    public class Navigation
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public string parentId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        public string appId { get; set; }

        /// <summary>
        /// 导航级别
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 模块信息
        /// </summary>
        public ModuleInfo moduleInfo { get; set; } = new ModuleInfo();

        /// <summary>
        /// 功能集合
        /// </summary>
        public List<Function> functions { get; set; } = new List<Function>();
    }
}
