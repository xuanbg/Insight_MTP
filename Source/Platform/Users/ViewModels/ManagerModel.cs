using System.Collections.Generic;
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
            init(view.gdvUser, "editItem", view.ppcUser, view.KeyInput, view.Search);
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
            list = result.data;
            closeWaitForm();
            if (!result.success) return;

            tab.totalRows = int.Parse(result.option.ToString()) ;
            view.grdUser.DataSource = list;
            view.gdvUser.FocusedRowHandle = handle;
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
                view.grdUser.DataSource = null;
            }
            else
            {
                tab.focusedRowHandle = index;
                handle = index;
                var obj = list[index];
                if (obj.id != item?.id)
                {
                    item = obj;
                    if (item.funcs == null)
                    {
                        item.funcs = dataModel.getFuncs(item.id);
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