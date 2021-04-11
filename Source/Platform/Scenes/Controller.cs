using System;
using Insight.Base.BaseForm.Controllers;
using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Utils;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Scenes.ViewModels;
using Insight.MTP.Client.Platform.Scenes.Views;

namespace Insight.MTP.Client.Platform.Scenes
{
    public class Controller : MdiController<Scene, SceneConfig, Manager, ManagerModel, DataModel>
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
        /// 新建场景
        /// </summary>
        public void newItem()
        {
            var scene = new Scene();
            var model = new SceneModel(scene, "新建场景");
            model.callbackEvent += (sender, args) =>
            {
                scene.id = dataModel.addScene(scene);
                if (scene.id == null)
                {
                    model.enableConfirm();
                    return;
                }

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
                if (!dataModel.updateScene(mdiModel.item))
                {
                    model.enableConfirm();
                    return;
                }

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
        public void newConfig()
        {
            var config = new SceneConfig {sceneId = mdiModel.item.id, creator = Setting.userName, createdTime = DateTime.Now};
            var model = new ConfigModel("新建场景配置", config, dataModel);
            model.callbackEvent += (sender, args) =>
            {
                config.id = dataModel.addSceneConfig(config);
                if (config.id == null)
                {
                    model.enableConfirm();
                    return;
                }

                mdiModel.item.configs.Add(config);
                mdiModel.refreshDetailGrid();

                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑场景配置
        /// </summary>
        public void editConfig()
        {
            var model = new ConfigModel("编辑场景配置", mdiModel.config, dataModel);
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateSceneConfig(mdiModel.config))
                {
                    model.enableConfirm();
                    return;
                }

                mdiModel.refreshDetailGrid();
                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除场景配置
        /// </summary>
        public void deleteConfig()
        {
            var msg = $"您确定要删除当前选定的场景配置吗？\r\n数据删除后将无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteSceneConfig(mdiModel.config))
            {
                mdiModel.item.configs.Remove(mdiModel.config);
                mdiModel.refreshDetailGrid();
            }
        }
    }
}