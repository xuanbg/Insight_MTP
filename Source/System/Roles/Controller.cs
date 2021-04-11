using Insight.Base.BaseForm.Controllers;
using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Utils;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Roles.ViewModels;
using Insight.MTP.Client.Setting.Roles.Views;
using Insight.Utils.Common;
using System;
using System.Linq;

namespace Insight.MTP.Client.Setting.Roles
{
    public class Controller : MdiController<Role, Member, Manager, ManagerModel, DataModel>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">模块信息</param>
        public Controller(ModuleDto info) : base(info) { }

        /// <summary>
        /// 刷新列表
        /// </summary>
        public void refresh()
        {
            mdiModel.loadData(mdiModel.tab.page);
        }

        /// <summary>
        /// 新建角色
        /// </summary>
        public void newItem()
        {
            var role = new Role();
            var apps = dataModel.getRoleApps();
            var model = new RoleModel(role, apps, "新建角色");
            model.callbackEvent += (sender, args) =>
            {
                role.id = dataModel.addRole(role);
                if (role.id == null)
                {
                    model.enableConfirm();
                    return;
                }

                mdiModel.list.Add(role);
                mdiModel.tab.addItems();

                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑角色
        /// </summary>
        public void editItem()
        {
            var apps = dataModel.getRoleApps();
            var model = new RoleModel(mdiModel.item, apps, "编辑角色");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateRole(mdiModel.item))
                {
                    model.enableConfirm();
                    return;
                }

                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        public void deleteItem()
        {
            var msg = $"您确定要删除角色{mdiModel.item.name}吗？\r\n数据删除后无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteRole(mdiModel.item))
            {
                mdiModel.list.Remove(mdiModel.item);
                mdiModel.tab.removeItems();
            }
        }

        /// <summary>
        /// 添加角色成员
        /// </summary>
        public void addMember()
        {
            var members = dataModel.getMemberOfUser(mdiModel.item.id);
            var model = new MemberModel(members, "添加角色成员");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.addMember(mdiModel.item.id, model.members))
                {
                    model.enableConfirm();
                    return;
                }

                mdiModel.item.members.AddRange(model.members);
                if (mdiModel.item.members.All(i => i.id != "1")) mdiModel.item.members.Add(new Member { id = "1", type = 0, name = "用户" });

                mdiModel.refreshTree();
                mdiModel.getMemberUsers();
                mdiModel.refreshUser();

                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 移除角色成员
        /// </summary>
        public void removeMember()
        {
            var msg = $"您确定要移除角色成员{mdiModel.member.name}吗？";
            if (!Messages.showConfirm(msg)) return;

            if (!dataModel.removeMember(mdiModel.item.id, mdiModel.member)) return;

            mdiModel.item.members.Remove(mdiModel.member);
            if (mdiModel.item.members.All(i => i.type != 1)) mdiModel.item.members.RemoveAll(i => i.id == "1");

            mdiModel.refreshTree();
            mdiModel.getMemberUsers();
            mdiModel.refreshUser();
        }

        /// <summary>
        /// 设置角色功能权限
        /// </summary>
        public void setFunc()
        {
            if (mdiModel.func == null) return;

            var func = Util.clone(mdiModel.func);
            var permit = mdiModel.func.permit;
            if (permit == null) func.permit = true;
            else if ((bool)permit) func.permit = false;
            else func.permit = null;

            if (dataModel.setFuncPermit(mdiModel.item.id, func))
            {
                mdiModel.func.permit = func.permit;
                mdiModel.func.type = 3 + (func.permit == null ? 2 : Convert.ToInt32(func.permit));

                mdiModel.refreshAction();
            }
        }
    }
}