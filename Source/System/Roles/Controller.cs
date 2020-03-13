using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Roles.ViewModels;
using Insight.MTP.Client.Setting.Roles.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Roles
{
    public class Controller : MdiController<Role, Manager, ManagerModel, DataModel>
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
            mdiModel.loadData(mdiModel.handle);
        }

        /// <summary>
        /// 新建角色
        /// </summary>
        public void newItem()
        {
            var role = new Role();
            var model = new WizardModel(role, "新建角色");
            model.callbackEvent += (sender, args) =>
            {
                role.id = dataModel.addRole(role);
                if (role.id == null) return;

                mdiModel.list.Add(role);
                mdiModel.tab.addItems();

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑角色
        /// </summary>
        public void editItem()
        {
            var model = new WizardModel(mdiModel.item, "编辑角色");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateRole(mdiModel.item)) return;

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        public void deleteItem()
        {
            var msg = "您确定要删除角色{mdiModel.item.name}吗？\r\n数据删除后无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteRole(mdiModel.item))
            {
                mdiModel.list.Remove(mdiModel.item);
                mdiModel.tab.removeItems();
            }
        }
        
    }
}