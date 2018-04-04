using System;
using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    /// <summary>
    /// �û�
    /// </summary>
    public class User
    {
        /// <summary>
        /// ID��Ψһ��ʶ
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// ����/�ǳ�
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// ��¼�˺�
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// �ֻ���
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// ע������
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// �Ƿ�Ԥ�ã�0���Զ���1��Ԥ��
        /// </summary>
        public bool isBuiltin { get; set; }

        /// <summary>
        /// �Ƿ�ʧЧ��0����Ч��1��ʧЧ
        /// </summary>
        public bool isInvalid { get; set; }

        /// <summary>
        /// ������ID
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime createTime { get; set; }

        /// <summary>
        /// �����û��Ĺ���Ȩ��
        /// </summary>
        public List<AppTree> funcs { get; set; }

        /// <summary>
        /// �����û�������Ȩ��
        /// </summary>
        public List<AppTree> datas { get; set; }
    }

    /// <summary>
    /// Ӧ����
    /// </summary>
    public class AppTree
    {
        /// <summary>
        /// ID��Ψһ��ʶ
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        public string parentId { get; set; }

        /// <summary>
        /// ͼ������
        /// </summary>
        public int nodeType { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// �ڵ�����
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// ��Ȩ
        /// </summary>
        public bool? permit { get; set; }
    }
}