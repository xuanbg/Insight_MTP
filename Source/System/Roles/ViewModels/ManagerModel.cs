using System.Collections.Generic;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.System.Roles.Views;
using Insight.Utils.BaseViewModels;

namespace Insight.MTP.Client.System.Roles.ViewModels
{
    public class ManagerModel : BaseMdiModel<Role, Manager, DataModel>
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
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
            view.GrdRole.DataSource = list;
            view.GdvRole.FocusedRowHandle = handle;
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
                view.GrdUser.DataSource = null;
            }
            else
            {
                tab.focusedRowHandle = index;
                handle = index;
                var obj = list[index];
                if (obj.id != item?.id)
                {
                    item = obj;
                    if (item.users == null)
                    {
                        item.users = dataModel.getFuncs(item.id);
                    }
                }
            }

            view.GrdUser.DataSource = item?.users;

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
            view.GdvUser.RefreshData();
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
                ["reset"] = item != null,
            };
            switchItemStatus(dict);
        }
    }
}