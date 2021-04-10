using System.Collections.Generic;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Schedules.Views;
using Insight.Base.BaseForm.ViewModels;

namespace Insight.MTP.Client.Platform.Schedules.ViewModels
{
    public class ManagerModel : BaseMdiModel<Schedule, Manager, DataModel>
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            initSearch(view.KeyInput, view.Search);
            initMainGrid(view.grdSchedule, view.gdvSchedule, view.pccSchedule);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="page">当前页</param>
        public void loadData(int page = 1)
        {
            showWaitForm();
            var result = dataModel.getSchedules(keyword, page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            list.Clear();
            item = null;

            list.AddRange(result.data);
            tab.totalRows = result.total;

            refreshToolBar();
        }

        /// <summary>
        /// 主列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            item = index < 0 || index >= list.Count ? null : list[index];

            refreshToolBar();
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        public void refreshGrid()
        {
            view.gdvSchedule.RefreshData();
            refreshToolBar();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private new void refreshToolBar()
        {
            buttonStatus = new Dictionary<string, bool>
            {
                ["execute"] = item != null && !item.invalid,
                ["deleteItem"] = item != null && item.invalid,
                ["disable"] = item != null && !item.invalid,
                ["enable"] = item != null && item.invalid,
            };

            base.refreshToolBar();
        }
    }
}