using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Templates.ViewModels;
using Insight.MTP.Client.Setting.Templates.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Templates
{
    public class Controller : MdiController<MessageTemp, Manager, ManagerModel, DataModel>
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
            mdiModel.loadData(mdiModel.tab.page, mdiModel.tab.focusedRowHandle);
        }

        /// <summary>
        /// 新建消息模板
        /// </summary>
        public void newItem()
        {
            var temp = new MessageTemp();
            var model = new TemplateModel(temp, "新建消息模板");
            model.callbackEvent += (sender, args) =>
            {
                temp.id = dataModel.addTemplate(temp);
                if (temp.id == null) return;

                mdiModel.list.Add(temp);
                mdiModel.tab.addItems();

                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑消息模板
        /// </summary>
        public void editItem()
        {
            var model = new TemplateModel(mdiModel.item, "编辑消息模板");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateTemplate(mdiModel.item)) return;

                model.closeDialog();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除消息模板
        /// </summary>
        public void deleteItem()
        {
            var msg = $"您确定要删除接口{mdiModel.item.title}的配置数据吗？\r\n数据删除后接口将无法访问！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteTemplate(mdiModel.item))
            {
                mdiModel.list.Remove(mdiModel.item);
                mdiModel.tab.removeItems();
            }
        }

        /// <summary>
        /// 禁用消息模板
        /// </summary>
        public void disable()
        {
            var msg = $"您确定要禁用消息模板{mdiModel.item.title}吗？";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.disableTemplates(mdiModel.item))
            {
                mdiModel.item.invalid = true;
                mdiModel.refreshGrid();
            }
        }

        /// <summary>
        /// 启用消息模板
        /// </summary>
        public void enable()
        {
            var msg = $"您确定要启用消息模板{mdiModel.item.title}吗？";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.enableTemplates(mdiModel.item))
            {
                mdiModel.item.invalid = false;
                mdiModel.refreshGrid();
            }
        }
    }
}