using System.Collections.Generic;
using Insight.MTP.Client.Common.Utils;
using Insight.Utils.Client;
using Insight.Utils.Common;

namespace Insight.MTP.Client.Common.Models
{
    public class DialogModel
    {
        private readonly List<InputItem> checkItems = new List<InputItem>();

        public TokenHelper token = Params.tokenHelper;
        public string server = Params.server;

        /// <summary>
        /// 设置一个输入检查对象
        /// </summary>
        /// <param name="key">输入对象的值</param>
        /// <param name="message">错误消息</param>
        /// <param name="clear">是否清除集合</param>
        public void SetCheckItem(string key, string message, bool clear = false)
        {
            if (clear) checkItems.Clear();

            var item = new InputItem{key = key, message = message};
            checkItems.Add(item);
        }

        /// <summary>
        /// 设置多个输入检查对象
        /// </summary>
        /// <param name="items">输入检查对象集合</param>
        /// <param name="clear">是否清除集合</param>
        public void SetCheckItems(IEnumerable<InputItem> items, bool clear = false)
        {
            checkItems.AddRange(items);
        }

        /// <summary>
        /// 检查输入检查对象是否都有值
        /// </summary>
        /// <returns>bool 对象是否都有值</returns>
        public bool InputExamine()
        {
            return new InputCheck(checkItems).result;
        }
    }
}