using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Users.ViewModels;
using Insight.MTP.Client.Platform.Users.Views;
using Insight.Utils.BaseControllers;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Users
{
    public class Controller : MdiController<User, Manager, ManagerModel, DataModel>
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
            mdiModel.loadData(mdiModel.tab.focusedRowHandle);
        }

        /// <summary>
        /// 新建用户
        /// </summary>
        public void newItem()
        {
            var user = new User{password = Util.hash("123456")};
            var model = new UserModel(user, "新建用户");
            model.callbackEvent += (sender, args) =>
            {
                user.id = dataModel.addUser(user);
                if (user.id == null) return;

                mdiModel.list.Add(user);
                mdiModel.tab.addItems();

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 编辑用户
        /// </summary>
        public void editItem()
        {
            var model = new UserModel(mdiModel.item, "编辑用户");
            model.callbackEvent += (sender, args) =>
            {
                if (!dataModel.updateUser(mdiModel.item)) return;

                model.close();
            };

            model.showDialog();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        public void deleteItem()
        {
            var msg = "您确定要删除用户{mdiModel.item.name}吗？\r\n数据删除后无法恢复！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.deleteUser(mdiModel.item))
            {
                mdiModel.list.Remove(mdiModel.item);
                mdiModel.tab.removeItems();
            }
        }

        /// <summary>
        /// 禁用用户
        /// </summary>
        public void disable()
        {
            var msg = $"您确定要禁用用户{mdiModel.item.name}吗？\r\n禁用后该用户不能登录系统！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.disableUser(mdiModel.item))
            {
                mdiModel.item.invalid = true;
                mdiModel.refreshGrid();
            }
        }

        /// <summary>
        /// 启用用户
        /// </summary>
        public void enable()
        {
            var msg = $"您确定要启用用户{mdiModel.item.name}吗？\r\n启用后该用户可正常登录系统！";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.enableUser(mdiModel.item))
            {
                mdiModel.item.invalid = false;
                mdiModel.refreshGrid();
            }
        }

        /// <summary>
        /// 重置用户密码
        /// </summary>
        public void reset()
        {
            var msg = $"您确定要重置用户{mdiModel.item.name}的密码吗？";
            if (!Messages.showConfirm(msg)) return;

            if (dataModel.resetPassword(mdiModel.item))
            {
                msg = $"用户{mdiModel.item.name}的密码已被重置，请尽快登录系统修改密码！";
                Messages.showMessage(msg);
            }
        }
    }
}