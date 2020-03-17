using System.Windows.Forms;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Tenants.ViewModels;
using Insight.MTP.Client.Platform.Tenants.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Tenants
{
    public class Controller : MdiController<Tenant, Manager, ManagerModel, DataModel>
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
            mdiModel.loadData(mdiModel.tab.page, mdiModel.tab.focusedRowHandle);
        }

        /// <summary>
        /// 新建租户
        /// </summary>
        public void newItem()
        {
            var tenant = new Tenant();
            var model = new TenantModel(tenant, "新建租户", dataModel);
            model.callbackEvent += (sender, args) =>
            {
                tenant.id = dataModel.addTenant(tenant);
                if (tenant.id == null) return;

                mdiModel.list.Add(tenant);
                mdiModel.tab.addItems();

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑租户
        /// </summary>
        public void editItem()
        {
            var model = new TenantModel(mdiModel.item, "编辑租户", dataModel);
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateTenant(mdiModel.item)) return;

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除租户
        /// </summary>
        public void deleteItem()
        {
            var msg = $"您确定要删除租户【{mdiModel.item.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteTenant(mdiModel.item))
            {
                mdiModel.list.Remove(mdiModel.item);
                mdiModel.tab.removeItems();
                mdiModel.refreshGrid();
            }
        }

        /// <summary>
        /// 审核租户
        /// </summary>
        public void audit()
        {
            var msg = $"您确定要通过租户【{mdiModel.item.name}】审核吗？\r\n通过选择【是】，不通过选择【否】。";
            var result = Messages.showQuestion(msg);
            if (result == DialogResult.Cancel) return;

            var status = result == DialogResult.Yes ? 1 : 2;
            if (dataModel.auditTenant(mdiModel.item.id, status))
            {
                mdiModel.item.status = status;
                mdiModel.refreshGrid();
            }
        }

        /// <summary>
        /// 禁用租户
        /// </summary>
        public void disable()
        {
            var msg = $"您确定要禁用租户【{mdiModel.item.name}】吗？\r\n禁用后该租户的用户将无法登录应用！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.disableTenant(mdiModel.item))
            {
                mdiModel.item.invalid = true;
                mdiModel.refreshGrid();
            }
        }

        /// <summary>
        /// 启用租户
        /// </summary>
        public void enable()
        {
            var msg = $"您确定要启用租户【{mdiModel.item.name}】吗？\r\n启用后该租户的用户将可以正常登录应用！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.enableTenant(mdiModel.item))
            {
                mdiModel.item.invalid = false;
                mdiModel.refreshGrid();
            }
        }

        /// <summary>
        /// 绑定应用
        /// </summary>
        public void bind()
        {
            var apps = dataModel.getApps(mdiModel.item.id);
            var model = new BindModel(apps, "绑定应用");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.bindApps(mdiModel.item.id, model.apps)) return;

                mdiModel.item.apps.AddRange(model.apps);
                mdiModel.refreshApp();
                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 解绑应用
        /// </summary>
        public void unbind()
        {
            var msg = $"您确定要解绑应用【{mdiModel.app.name}】吗？\r\n解绑后该租户的用户将使用该应用！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.unbindApp(mdiModel.app))
            {
                mdiModel.item.apps.Remove(mdiModel.app);
                mdiModel.refreshApp();
            }
        }

        /// <summary>
        /// 续租应用
        /// </summary>
        public void rent()
        {
            var model = new RentModel(mdiModel.app, "续租应用");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.rentApp(mdiModel.app)) return;

                mdiModel.refreshApp();
                model.close();
            };

            model.showDialog();
        }
    }
}