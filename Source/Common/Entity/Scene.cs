using System;
using System.Collections.Generic;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Common.Entity
{
    public class Scene
    {
        /// <summary>
        /// UUID主键
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 场景编号
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 发送类型：0、未定义；1、仅消息(001)；2、仅推送(010)；3、推送+消息(011)；4、仅短信(100)
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 消息标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 消息标签
        /// </summary>
        public string tag { get; set; }

        /// <summary>
        /// 消息参数
        /// </summary>
        public List<string> param { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        public string paramVal => Util.serialize(param);

        /// <summary>
        /// 模板配置集合
        /// </summary>
        public List<SceneConfig> configs { get; set; } = new List<SceneConfig>();
    }

    public class SceneConfig
    {
        /// <summary>
        /// UUID主键
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 场景ID
        /// </summary>
        public string sceneId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        public string appId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        public string appName { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 消息签名
        /// </summary>
        public string sign { get; set; }

        /// <summary>
        /// 消息有效时长(小时)
        /// </summary>
        public int expire { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string creator { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createdTime { get; set; }
    }
}
