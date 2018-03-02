﻿using System;
using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    public class Tenant
    {
        /// <summary>
        /// ID，唯一标识
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 简称
        /// </summary>
        public string alias { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public byte[] icon { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string contact { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 所在省/直辖市
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 所在市/地区
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 所在区/县
        /// </summary>
        public string county { get; set; }

        /// <summary>
        /// 街道楼门号
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 租户到期时间
        /// </summary>
        public DateTime expireDate { get; set; }

        /// <summary>
        /// 是否预置：0、自定；1、预置
        /// </summary>
        public bool isBuiltin { get; set; }

        /// <summary>
        /// 是否可见：0、不可见；1、可见
        /// </summary>
        public bool isVisible { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createTime { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public List<App> apps { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public List<User> users { get; set; }
    }
}
