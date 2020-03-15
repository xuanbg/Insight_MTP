using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    /// <summary>
    /// ��ɫ
    /// </summary>
    public class Role
    {
        /// <summary>
        /// ΨһID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// �⻧ID
        /// </summary>
        public string tenantId { get; set; }

        /// <summary>
        /// Ӧ��ID
        /// </summary>
        public string appId { get; set; }

        /// <summary>
        /// Ӧ������
        /// </summary>
        public string appName { get; set; }

        /// <summary>
        /// ��ɫ����
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// �Ƿ�Ԥ�ã�0���Զ���1��Ԥ��
        /// </summary>
        public bool builtin { get; set; }

        /// <summary>
        /// ��ɫ��Ա
        /// </summary>
        public List<Member> members { get; set; }

        /// <summary>
        /// ��ɫ��Ա�û�
        /// </summary>
        public List<User> users { get; set; }

        /// <summary>
        /// ��ɫ����Ȩ��
        /// </summary>
        public List<AppTree> funcs { get; set; }
    }

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
        /// ��¼����
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// �Ƿ�Ԥ�ã�0���Զ���1��Ԥ��
        /// </summary>
        public bool builtin { get; set; }

        /// <summary>
        /// �Ƿ�ʧЧ��0����Ч��1��ʧЧ
        /// </summary>
        public bool invalid { get; set; }

        /// <summary>
        /// ��ɫ����Ȩ��
        /// </summary>
        public List<AppTree> funcs { get; set; }
    }

    /// <summary>
    /// ��ɫ��Ա
    /// </summary>
    public class Member
    {
        /// <summary>
        /// ��ԱID��Ψһ��ʶ
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        public string parentId { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public int? index { get; set; }

        /// <summary>
        /// ��Ա����
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string remark { get; set; }
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
        public int type { get; set; }

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
        /// ��Ȩ״̬
        /// </summary>
        public bool? permit { get; set; }
    }

    /// <summary>
    /// ��ɫ����Ӧ��
    /// </summary>
    public class RoleApp
    {
        /// <summary>
        /// Ӧ��ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Ӧ������
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Ӧ�ü��
        /// </summary>
        public string alias { get; set; }
    }
}