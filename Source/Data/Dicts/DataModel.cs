using System.Collections.Generic;
using Insight.Base.BaseForm.Utils;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Data.Dicts
{
    public class DataModel
    {
        private const string service = "/common/dict";

        /// <summary>
        /// 查询字典数据
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="page">页码</param>
        /// <param name="size">每页行数</param>
        /// <returns>字典数据集合</returns>
        public Result<List<DictDto>> getDicts(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/dicts";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"page", page},
                {"size", size}
            };
            var client = new HttpClient<List<DictDto>>();

            return client.getResult(url, dict);
        }

        /// <summary>
        /// 获取字典键值集合
        /// </summary>
        /// <param name="id">字典数据ID</param>
        /// <returns>字典键值集合</returns>
        public List<DictKeyDto> getDictKeys(string id)
        {
            var url = $"{service}/v1.0/dicts/{id}";
            var client = new HttpClient<List<DictKeyDto>>();

            return client.getData(url);
        }


        /// <summary>
        /// 获取应用集合
        /// </summary>
        /// <returns>应用集合</returns>
        public Result<List<App>> getApps()
        {
            const string url = "/base/resource/v1.0/apps";
            var dict = new Dictionary<string, object>
            {
                {"page", 1},
                {"size", 999}
            };
            var client = new HttpClient<List<App>>();

            return client.getResult(url, dict);
        }

        /// <summary>
        /// 新增字典键值
        /// </summary>
        /// <param name="dto">字典键值DTO</param>
        /// <returns>字典键值ID</returns>
        public string addDictKey(DictKeyDto dto)
        {
            if (dto == null) return null;

            var msg = $"新增字典键值【{dto.value}】数据失败！";
            var url = $"{service}/v1.0/dicts/keys";
            var client = new HttpClient<string>();

            return client.commit(url, dto, msg, RequestMethod.POST);
        }

        /// <summary>
        /// 编辑字典键值
        /// </summary>
        /// <param name="dto">字典键值DTO</param>
        /// <returns>是否更新成功</returns>
        public bool editDictKey(DictKeyDto dto)
        {
            if (dto == null) return false;

            var msg = $"更新字典键值【{dto.value}】数据失败！";
            var url = $"{service}/v1.0/dicts/keys";
            var client = new HttpClient<object>();

            return client.put(url, dto, msg);
        }
        
        /// <summary>
        /// 删除字典键值
        /// </summary>
        /// <param name="dto">字典键值DTO</param>
        /// <returns>是否删除成功</returns>
        public bool deleteDictKey(DictKeyDto dto)
        {
            if (dto == null) return false;

            var msg = $"对不起，无法删除字典键值【{dto.value}】数据！";
            var url = $"{service}/v1.0/dicts/keys";
            var client = new HttpClient<object>();

            return client.delete(url, dto.id, msg);
        }
    }
}
