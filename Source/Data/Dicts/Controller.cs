using Insight.Base.BaseForm.Controllers;
using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Utils;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Data.Dicts.ViewModels;
using Insight.MTP.Client.Data.Dicts.Views;

namespace Insight.MTP.Client.Data.Dicts
{
    public class Controller : MdiController<DictDto, DictKeyDto, Manager, ManagerModel, DataModel>
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
        /// 新增字典
        /// </summary>
        public void newItem()
        {
            var dict = new DictDto();
            var apps = dataModel.getApps();
            var model = new DictModel(dict, apps, "新增字典");
            model.callbackEvent += (sender, args) =>
            {
                dict.id = dataModel.addDict(model.item);
                if (dict.id == null) return;

                mdiModel.list.Add(dict);
                mdiModel.tab.addItems();

                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑字典
        /// </summary>
        public void editItem()
        {
            var apps = dataModel.getApps();
            var model = new DictModel(mdiModel.item, apps, "编辑字典");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.editDict(model.item)) return;

                mdiModel.refreshGrid();
                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除字典
        /// </summary>
        public void deleteItem()
        {
            var msg = $"您确定要删除字典{mdiModel.item.name}吗？\r\n数据删除后无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteDict(mdiModel.item))
            {
                mdiModel.list.Remove(mdiModel.item);
                mdiModel.tab.removeItems();
            }
        }

        /// <summary>
        /// 新增键值
        /// </summary>
        public void newValue()
        {
            var key = new DictKeyDto { dictId = mdiModel.item.id };
            var model = new DictKeyModel(key, "新增键值");
            model.callbackEvent += (sender, args) =>
            {
                key.id = dataModel.addDictKey(model.item);
                if (key.id == null) return;

                key.tenantId = Setting.tenantId;
                mdiModel.item.keys.Add(key);
                mdiModel.refreshKeyGrid();

                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑键值
        /// </summary>
        public void editValue()
        {
            var model = new DictKeyModel(mdiModel.key, "编辑键值");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.editDictKey(model.item)) return;

                mdiModel.refreshKeyGrid();
                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除键值
        /// </summary>
        public void deleteValue()
        {
            var msg = $"您确定要删除键值{mdiModel.key.value}吗？\r\n数据删除后无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteDictKey(mdiModel.key))
            {
                mdiModel.item.keys.Remove(mdiModel.key);
                mdiModel.refreshKeyGrid();
            }
        }
    }
}