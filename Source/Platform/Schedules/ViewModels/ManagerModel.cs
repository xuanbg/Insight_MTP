using System.Collections.Generic;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Schedules.Views;
using Insight.Utils.BaseViewModels;

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
        /// <param name="handle">行号</param>
        public void loadData(int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getSchedules(keyWord, tab.page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            list.Clear();
            item = null;

            list.AddRange(result.data);
            tab.totalRows = int.Parse(result.option.ToString());
            view.gdvSchedule.RefreshData();
            view.gdvSchedule.FocusedRowHandle = handle;

            refreshToolBar();
        }

        /// <summary>
        /// 主列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            item = index < 0 ? null : list[index];

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
        private void refreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["execute"] = item != null && !item.invalid,
                ["deleteItem"] = item != null && item.invalid,
                ["disable"] = item != null && !item.invalid,
                ["enable"] = item != null && item.invalid,
            };
            switchItemStatus(dict);
        }
    }
}