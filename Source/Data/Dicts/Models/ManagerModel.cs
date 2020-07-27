using System.Collections.Generic;
using System.Linq;
using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Data.Dicts.Views;

namespace Insight.MTP.Client.Data.Dicts.Models
{
    public class ManagerModel : BaseMdiModel<DictDto, Manager, DataModel>
    {
        public DictKeyDto key;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            initSearch(view.KeyInput, view.Search);
            initMainGrid(view.grdDict, view.gdvDict, view.upcDict);
            initGrid(view.grdKey, view.gdvKey, "keyChanged", "editValue");
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="page">当前页</param>
        public void loadData(int page = 1)
        {
            showWaitForm();
            var result = dataModel.getDicts(keyword, page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

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
            if (index < 0 || index >= list.Count)
            {
                item = null;
                key = null;
                view.grdKey.DataSource = null;
                view.gdvKey.FocusedRowHandle = -1;
                refreshToolBar();

                return;
            }

            item = list[index];
            if (!item.keys.Any())
            {
                item.keys = dataModel.getDictKeys(item.id);
            }

            view.grdKey.DataSource = item.keys;
            view.gdvKey.FocusedRowHandle = 0;

            refreshToolBar();
        }

        /// <summary>
        /// 字典键值选择
        /// </summary>
        /// <param name="index">List下标</param>
        public void keyChanged(int index)
        {
            key = index < 0 || index >= item.keys.Count ? null : item.keys[index];

            refreshToolBar();
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        public void refreshGrid()
        {
            view.gdvDict.RefreshData();
            refreshToolBar();
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        public void refreshKeyGrid()
        {
            view.gdvKey.RefreshData();
            refreshToolBar();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void refreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editItem"] = item != null,
                ["deleteItem"] = item != null,
                ["newValue"] = item != null,
                ["editValue"] = key != null && key.tenantId == null,
                ["deleteValue"] = key != null && key.tenantId == null
            };
            switchItemStatus(dict);
        }
    }
}