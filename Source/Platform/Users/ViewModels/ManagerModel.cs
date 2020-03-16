using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Users.Views;
using Insight.Utils.BaseViewModels;

namespace Insight.MTP.Client.Platform.Users.ViewModels
{
    public class ManagerModel : BaseMdiModel<User, Manager, DataModel>
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            initSearch(view.KeyInput, view.Search);
            initMainGrid(view.grdUser, view.gdvUser, view.ppcUser);
            initTree(view.treAction);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="handle">行号</param>
        public void loadData(int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getUsers(keyWord, tab.page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

            list.AddRange(result.data);
            tab.totalRows = result.total ;
            view.gdvUser.RefreshData();
            view.gdvUser.FocusedRowHandle = handle;

            refreshToolBar();
        }

        /// <summary>
        /// 主列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            if (index < 0)
            {
                item = null;
            }
            else
            {
                var id = item?.id;
                item = list[index];
                if (item.id != id)
                {
                    if (!item.funcs.Any())
                    {
                        var funcs = dataModel.getFuncs(item.id);
                        if (funcs != null) item.funcs.AddRange(funcs);
                    }
                }
            }

            view.treAction.DataSource = item?.funcs;
            view.treAction.ExpandToLevel(1);

            refreshToolBar();
        }

        /// <summary>
        /// 刷新树数据
        /// </summary>
        public void refreshTree()
        {
            refreshToolBar();
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        public void refreshGrid()
        {
            view.gdvUser.RefreshData();
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
                ["disable"] = item != null && !item.invalid,
                ["enable"] = item != null && item.invalid,
                ["reset"] = item != null,
            };
            switchItemStatus(dict);
        }
    }
}