using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Scenes.ViewModels;
using Insight.MTP.Client.Setting.Scenes.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Scenes
{
    public class Controller : MdiController<Scene, Manager, ManagerModel, DataModel>
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
        /// 新建场景
        /// </summary>
        public void newItem()
        {
            var scene = new Scene();
            var model = new SceneModel(scene, "新建场景");
            model.callbackEvent += (sender, args) =>
            {
                scene.id = dataModel.addScene(scene);
                if (scene.id == null) return;

                mdiModel.list.Add(scene);
                mdiModel.tab.addItems();

                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑场景
        /// </summary>
        public void editItem()
        {
            var model = new SceneModel(mdiModel.item, "编辑场景");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateScene(mdiModel.item)) return;

                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除场景
        /// </summary>
        public void deleteItem()
        {
            var msg = $"您确定要删除场景【{mdiModel.item.name}】吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteScene(mdiModel.item))
            {
                mdiModel.list.Remove(mdiModel.item);
                mdiModel.tab.removeItems();
            }
        }

        /// <summary>
        /// 新建场景配置
        /// </summary>
        public void addConfig()
        {
            var config = new TempConfig{sceneId = mdiModel.item.id};
            var temps = dataModel.getTemplates();
            var apps = dataModel.getApps();
            var model = new ConfigModel(config, temps, apps, "新增场景配置");
            model.callbackEvent += (sender, args) =>
            {
                config.id = dataModel.bindTemps(config);
                if (config.id == null) return;

                mdiModel.addConfig(config);
                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除场景配置
        /// </summary>
        public void removeConfig()
        {
            var msg = $"您确定要删除【{mdiModel.item.name}】配置的模板{mdiModel.config.template}吗？";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.unbindTemp(mdiModel.config))
            {
                mdiModel.removeConfig();
            }
        }
    }
}