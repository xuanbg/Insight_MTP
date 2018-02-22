using System;
using System.Collections.Generic;

namespace Insight.MTP.Client.Common.Entity
{
    /// <summary>
    /// ��֯����
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// ��֯����ΨһID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// ���ڵ�ID
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// �ڵ�����
        /// </summary>
        public int NodeType { get; set; }

        /// <summary>
        /// �ڵ���������
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// ��֯��������
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// ��֯��������
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ��֯�������
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// ��֯����ȫ��
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// ��λID
        /// </summary>
        public Guid? PositionId { get; set; }

        /// <summary>
        /// �Ƿ���Ч
        /// </summary>
        public bool Validity { get; set; }

        /// <summary>
        /// ������ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// ְλ��Ա
        /// </summary>
        public List<MemberUser> Members { get; set; }
    }

    /// <summary>
    /// �û�
    /// </summary>
    public class User
    {
        /// <summary>
        /// �û�ΨһID
        /// </summary>
        public Guid id { get; set; }

        /// <summary>
        /// �û���
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// ��¼�˺�
        /// </summary>
        public string loginName { get; set; }

        /// <summary>
        /// �û�����
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// �û�����
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public bool builtIn { get; set; }

        /// <summary>
        /// �Ƿ���Ч
        /// </summary>
        public bool validity { get; set; }

        /// <summary>
        /// ������ID
        /// </summary>
        public Guid creatorUserId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime createTime { get; set; }

        /// <summary>
        /// �û�����Ȩ����Ȩ��
        /// </summary>
        public List<RoleAction> Actions { get; set; }

        /// <summary>
        /// �û�����Ȩ����Ȩ��
        /// </summary>
        public List<RoleData> Datas { get; set; }
    }

    /// <summary>
    /// �û���
    /// </summary>
    public class UserGroup
    {
        /// <summary>
        /// ΨһID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// �û�������
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// �û�������
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public bool BuiltIn { get; set; }

        /// <summary>
        /// ������ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// �û����Ա
        /// </summary>
        public List<MemberUser> Members { get; set; }
    }

    /// <summary>
    /// ��ɫ
    /// </summary>
    public class Role
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// ��ɫ����
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ��ɫ����
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public bool BuiltIn { get; set; }

        /// <summary>
        /// �Ƿ����
        /// </summary>
        public bool Validity { get; set; }

        /// <summary>
        /// ������ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// ��ɫ����Ȩ�޼���
        /// </summary>
        public List<RoleAction> Actions { get; set; }

        /// <summary>
        /// ��ɫ����Ȩ�޼���
        /// </summary>
        public List<RoleData> Datas { get; set; }

        /// <summary>
        /// ��ɫ��Ա
        /// </summary>
        public List<RoleMember> Members { get; set; }
    }

    /// <summary>
    /// ��ɫ��Ա
    /// </summary>
    public class RoleMember
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// ���ڵ�ID
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// ��ԱID
        /// </summary>
        public Guid MemberId { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// �ڵ����ͣ���Ա���ͣ�1���û���2���û��飻3����λ��
        /// </summary>
        public int NodeType { get; set; }

        /// <summary>
        /// �ڵ�����
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// ��ɫ����Ȩ��
    /// </summary>
    public class RoleAction
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// ���ڵ�ID�����ݽڵ㣺ҵ��ģ��ID��
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// ģ�鹦��ID
        /// </summary>
        public Guid ActionId { get; set; }

        /// <summary>
        /// ԭȨ�ޣ�0��ֻ����1����д
        /// </summary>
        public int? Action { get; set; }

        /// <summary>
        /// ��Ȩ�ޣ�0��ֻ����1����д
        /// </summary>
        public int? Permit { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// �ڵ�����
        /// </summary>
        public int NodeType { get; set; }

        /// <summary>
        /// �ڵ�����
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// �ڵ�Ȩ�����
        /// </summary>
        public string Description { get; set; }
    }

    /// <summary>
    /// ��ɫ����Ȩ��
    /// </summary>
    public class RoleData
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// ���ڵ�ID�����ݽڵ㣺ҵ��ģ��ID��
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// ������Ȩģʽ��0�����ģʽ��1���û�ģʽ��2������ģʽ
        /// </summary>
        public int Mode { get; set; }

        /// <summary>
        /// ģʽID����/�û�ID������ģʽ��
        /// </summary>
        public Guid ModeId { get; set; }

        /// <summary>
        /// ԭȨ�ޣ�0��ֻ����1����д
        /// </summary>
        public int? Permission { get; set; }

        /// <summary>
        /// ��Ȩ�ޣ�0��ֻ����1����д
        /// </summary>
        public int? Permit { get; set; }

        /// <summary>
        /// ���
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// �ڵ�����
        /// </summary>
        public int NodeType { get; set; }

        /// <summary>
        /// �ڵ�����
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// �ڵ�Ȩ�����
        /// </summary>
        public string Description { get; set; }
    }

    /// <summary>
    /// ���뷽��
    /// </summary>
    public class Coding
    {
        /// <summary>
        /// ΨһID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// �����ʽ
        /// </summary>
        public string CodeFormat { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public string SerialFormat { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// �Ƿ���Ч
        /// </summary>
        public bool Validity { get; set; }

        /// <summary>
        /// ��������ID
        /// </summary>
        public Guid? CreatorDeptId { get; set; }

        /// <summary>
        /// ������ID
        /// </summary>
        public Guid CreatorUserId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// �����¼����
        /// </summary>
        public List<CodeRecord> Records { get; set; }

        /// <summary>
        /// ��������¼����
        /// </summary>
        public List<CodeAllot> Allots { get; set; }
    }

    /// <summary>
    /// �����¼
    /// </summary>
    public class CodeRecord
    {
        /// <summary>
        /// ΨһID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// �����ʶ
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// ��ǰ��ˮ
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// ��¼��
        /// </summary>
        public int RecordCount { get; set; }

        /// <summary>
        /// ������ˮ����ʱ��
        /// </summary>
        public DateTime LastRecordTime { get; set; }
    }

    /// <summary>
    /// �Ŷη����¼
    /// </summary>
    public class CodeAllot
    {
        /// <summary>
        /// ΨһID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// ӵ����
        /// </summary>
        public string OwnerUser { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string BillType { get; set; }

        /// <summary>
        /// ����Ŷ�
        /// </summary>
        public string CodeArea { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public string AllotUser { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}