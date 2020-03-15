using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Interfaces.ViewModels;
using Insight.MTP.Client.Setting.Interfaces.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Interfaces
{
    public class Controller : MdiController<Interface, Manager, ManagerModel, DataModel>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="info">模块信息</param>
        public Controller(ModuleDto info):base(info){}

        /// <summary>
        /// 刷新列表
        /// </summary>
        public void refresh()
        {
            mdiModel.loadData(mdiModel.handle);
        }

        /// <summary>
        /// 新建接口配置
        /// </summary>
        public void newItem()
        {
            var config = new Interface();
            var model = new InterfaceModel(config, "新建接口配置");
            model.callbackEvent += (sender, args) =>
            {
                config.id = dataModel.addInterface(config);
                if (config.id == null) return;

                mdiModel.list.Add(config);
                mdiModel.tab.addItems();

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑接口配置
        /// </summary>
        public void editItem()
        {
            var model = new InterfaceModel(mdiModel.item, "编辑接口配置");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateInterface(mdiModel.item)) return;

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除接口配置
        /// </summary>
        public void deleteItem()
        {
            var msg = "您确定要删除接口{mdiModel.item.name}的配置数据吗？\r\n数据删除后接口将无法访问！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteInterface(mdiModel.item))
            {
                mdiModel.list.Remove(mdiModel.item);
                mdiModel.tab.removeItems();
            }
        }

        /// <summary>
        /// 重新加载接口配置数据
        /// </summary>
        public void load()
        {
            var msg = "您确定要重新加载接口配置数据吗？";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.loadInterfaces())
            {
                msg = "接口配置数据已加载。";
                Messages.showMessage(msg);
            }
        }
    }
}