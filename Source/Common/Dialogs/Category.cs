using System;
using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.BaseForm;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Common.Dialogs
{
    public partial class Category : BaseDialog
    {

        #region 属性

        /// <summary>
        /// 模块Id
        /// </summary>
        public Guid ModuleId { private get; set; }

        /// <summary>
        /// 是否可编辑根分类
        /// </summary>
        public bool AllowEditRoot { private get; set; }

        #endregion

        #region 变量声明

        private MemberUser _Category;
        private readonly List<MemberUser> _Categorys = new List<MemberUser>();
        private readonly string _ParentId = null;
        private int _IndexValue;
        private int _Index;

        #endregion

        #region 构造方法

        public Category()
        {
            InitializeComponent();
        }

        #endregion

        #region 界面事件

        private void Category_Load(object sender, EventArgs e)
        {
            //var result = Interface.Categorys(ModuleId);

                _Category = new MemberUser();
            //_ParentId = IsEdit ? _Category.ParentId : (ObjectId == Guid.Empty) ? null : (Guid?)ObjectId;
            InitInfo();
        }
        
        /// <summary>
        /// EditValue发生变化后：
        /// 1、改变索引值
        /// 2、如新的父分类下存在重名，提示用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tleParent_EditValueChanged(object sender, EventArgs e)
        {
            var id = trlParent.EditValue.ToString();
            SetIndexValue(id);

            var list = _Categorys.Where(c => c.id == id && c.Name == txtName.Text.Trim());
            if (list.Any())
            {
                Messages.ShowMessage("您所选择的父分类下已经存在同名分类！请修改分类名称或重新选择父分类。");
            }
        }

        /// <summary>
        /// 父节点为根被选中/取消选中时切换父节点EditValue和控件可用状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkRoot_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRoot.Checked)
            {
                trlParent.EditValue = null;
                trlParent.Enabled = false;
            }
            else
            {
                trlParent.EditValue = _ParentId;
                trlParent.Enabled = true;
            }
        }

        #endregion

        #region 私有方法

        private void InitInfo()
        {
            //_ParentId = IsEdit ? _Category.ParentId : (ObjectId == Guid.Empty) ? null : (Guid?)ObjectId;
            Text = "新建分类";

            if (_Categorys.Any())
            {
                    RemoveNode(_Category.id);
            }
            else
            {
                chkRoot.Enabled = false;
                _IndexValue = 1;
            }
            var list = new List<TreeLookUpMember>();
            Format.InitTreeListLookUpEdit(trlParent, list);

            trlParent.EditValue = _ParentId;
            chkRoot.Checked = trlParent.EditValue == null;
            chkRoot.Enabled = AllowEditRoot;
            txtName.EditValue = _Category.Name;
            memDescription.EditValue = _Category.remark;
        }

        /// <summary>
        /// 移除无关节点（自身及子节点）
        /// </summary>
        private void RemoveNode(string id)
        {
        }

        /// <summary>
        /// 递归删除子节点
        /// </summary>
        /// <param name="id"></param>
        private void SubNodes(string id)
        {
        }

        /// <summary>
        /// 设置Index值
        /// </summary>
        /// <param name="id"></param>
        private void SetIndexValue(string id)
        {
            var list = _Categorys.Where(c => c.id == id && c.Name == txtName.Text.Trim()).ToList();
            var maxValue = list.Count + 1;
            _IndexValue = maxValue;
            _Index = id == _ParentId ? _IndexValue : maxValue;
            spiIndex.Properties.MinValue = 1;
            spiIndex.Properties.MaxValue = maxValue;
            spiIndex.Value = _Index;
        }

        /// <summary>
        /// 数据合法性校验
        /// </summary>
        /// <returns></returns>
        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                Messages.ShowError("分类名称不能为空！请输入正确的名称。");
                txtName.Focus();
                return false;
            }

            if (_Category.Name != txtName.Text.Trim())
            {
                Messages.ShowError($"对不起，在父分类【{trlParent.Text}】中已存在名称为【{txtName.Text}】的分类！\n\r请修改分类名称后再点击确定按钮保存数据。");
                txtName.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(txtAlias.Text.Trim()) && _Category.Name != txtAlias.Text.Trim())
            {
                Messages.ShowError($"对不起，已经存在名为【{txtAlias.Text}】的简称！分类简称可以为空，但不能重复。");
                txtAlias.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(txtCode.Text.Trim()) && _Category.Name != txtCode.Text.Trim())
            {
                Messages.ShowError($"对不起，已经存在名为【{txtCode.Text}】的编码！分类编码可以为空，但不能重复。");
                txtCode.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// 更新对象实体属性值
        /// </summary>
        private void ObjectAssign()
        {
            _Category.remark = memDescription.EditValue == null ? null : memDescription.Text.Trim();
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 点击确定后提交更新或插入新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //protected override void Confirm_Click(object sender, EventArgs e)
        //{
        //    if (!IsValid()) return;

        //    ObjectAssign();

        //        //if (IsEdit)
        //        //{
        //        //    if (cli.UpdateCategory(MainForm.Session, _Category, _Index, _ParentId, _IndexValue))
        //        //        DialogResult = DialogResult.OK;
        //        //    else
        //        //        General.ShowError("对不起，因为未知的原因，更新" + _Category.Name + "】失败！\r\n如出现重复失败的情况，请联系管理员。");
        //        //}
        //        //else
        //        //{
        //        //    _Category.ModuleId = ModuleId;
        //        //    if (cli.AddCategory(MainForm.Session, _Category, _IndexValue))
        //        //        DialogResult = DialogResult.OK;
        //        //    else
        //        //        General.ShowError("对不起，因为未知的原因，新建" + _Category.Name + "】失败！\r\n如出现重复失败的情况，请联系管理员。");
        //        //}
        //}

        #endregion

    }
}
