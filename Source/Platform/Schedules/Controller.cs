using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Schedules.ViewModels;
using Insight.MTP.Client.Platform.Schedules.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Schedules
{
    public class Controller : MdiController<Schedule, Manager, ManagerModel, DataModel>
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
        /// 执行计划任务
        /// </summary>
        public void execute()
        {
            var msg = $"您确定要立即执行选中的计划任务吗？\r\n该任务原计划于北京时间{mdiModel.item.taskTime}执行";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.executeSchedule(mdiModel.item.id))
            {
                mdiModel.list.Remove(mdiModel.item);
                mdiModel.tab.removeItems();
                mdiModel.refreshGrid();
            }
        }

        /// <summary>
        /// 删除计划任务
        /// </summary>
        public void deleteItem()
        {
            var msg = "您确定要删除选中的计划任务吗？\r\n数据删除后无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteSchedule(mdiModel.item.id))
            {
                mdiModel.list.Remove(mdiModel.item);
                mdiModel.tab.removeItems();
                mdiModel.refreshGrid();
            }
        }

        /// <summary>
        /// 停用计划任务
        /// </summary>
        public void disable()
        {
            var msg = "您确定要禁用选中的计划任务吗？\r\n禁用后该计划任务不再按计划执行！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.disableSchedule(mdiModel.item.id))
            {
                mdiModel.item.invalid = true;
                mdiModel.refreshGrid();
            }
        }

        /// <summary>
        /// 启用计划任务
        /// </summary>
        public void enable()
        {
            var msg = "您确定要启用选中的计划任务吗？\r\n启用后该计划任务将继续按计划执行！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.enableSchedule(mdiModel.item.id))
            {
                mdiModel.item.invalid = false;
                mdiModel.refreshGrid();
            }
        }
    }
}