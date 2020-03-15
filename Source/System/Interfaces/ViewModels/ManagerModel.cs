using System.Collections.Generic;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Interfaces.Views;
using Insight.Utils.BaseViewModels;

namespace Insight.MTP.Client.Setting.Interfaces.ViewModels
{
    public class ManagerModel : BaseMdiModel<Interface, Manager, DataModel>
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            init(view.gdvInterface, "editItem", view.pccInterface, view.KeyInput, view.Search);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="handle">行号</param>
        public void loadData(int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getInterfaces(keyWord, tab.page, tab.size);
            list = result.data;
            closeWaitForm();
            if (!result.success) return;

            tab.totalRows = int.Parse(result.option.ToString()) ;
            view.grdInterface.DataSource = list;
            view.gdvInterface.FocusedRowHandle = handle;

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
        /// 刷新工具条按钮状态
        /// </summary>
        private void refreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editItem"] = item != null,
                ["deleteItem"] = item != null
            };
            switchItemStatus(dict);
        }
    }
}