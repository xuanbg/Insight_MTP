using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Utils;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Common;
using Insight.Utils.Entity;
using System.Collections.Generic;

namespace Insight.MTP.Client.Data.Dicts
{
    public class DataModel
    {
        private const string service = "/common/dict";

        /// <summary>
        /// 查询字典数据
        /// </summary>
        /// <param name="keyword">查询关键词</param>
        /// <param name="pageNum">页码</param>
        /// <param name="pageSize">每页行数</param>
        /// <returns>字典数据集合</returns>
        public Result<List<DictDto>> getDicts(string keyword, int page, int size)
        {
            var url = $"{service}/v1.0/dicts";
            var dict = new Dictionary<string, object>
            {
                {"keyword", keyword},
                {"pageNum", page},
                {"pageSize", size}
            };
            var client = new HttpClient<List<DictDto>>(url);

            return client.getResult(dict);
        }

        /// <summary>
        /// 获取字典键值集合
        /// </summary>
        /// <param name="id">字典数据ID</param>
        /// <returns>字典键值集合</returns>
        public List<DictKeyDto> getDictKeys(string id)
        {
            var url = $"{service}/v1.0/dicts/{id}";
            var client = new HttpClient<List<DictKeyDto>>(url);

            return client.getData();
        }


        /// <summary>
        /// 获取应用集合
        /// </summary>
        /// <returns>应用集合</returns>
        public List<LookUpMember> getApps()
        {
            const string url = "/base/resource/v1.0/apps";
            var dict = new Dictionary<string, object>
            {
                {"pageNum", 1},
                {"pageSize", 999}
            };
            var client = new HttpClient<List<LookUpMember>>(url);

            return client.getData(dict);
        }

        /// <summary>
        /// 新增字典
        /// </summary>
        /// <param name="dto">字典DTO</param>
        /// <returns>字典ID</returns>
        public string addDict(DictDto dto)
        {
            if (dto == null) return null;

            var url = $"{service}/v1.0/dicts";
            var client = new HttpClient<string>(url);

            return client.commit(RequestMethod.POST, dto);
        }

        /// <summary>
        /// 编辑字典
        /// </summary>
        /// <param name="dto">字典DTO</param>
        /// <returns>是否更新成功</returns>
        public bool editDict(DictDto dto)
        {
            if (dto == null) return false;

            var url = $"{service}/v1.0/dicts/{dto.id}";
            var client = new HttpClient<object>(url);

            return client.put(dto);
        }

        /// <summary>
        /// 删除字典
        /// </summary>
        /// <param name="dto">字典DTO</param>
        /// <returns>是否删除成功</returns>
        public bool deleteDict(DictDto dto)
        {
            if (dto == null) return false;

            var url = $"{service}/v1.0/dicts/{dto.id}";
            var client = new HttpClient<object>(url);

            return client.delete();
        }

        /// <summary>
        /// 新增字典键值
        /// </summary>
        /// <param name="dto">字典键值DTO</param>
        /// <returns>字典键值ID</returns>
        public string addDictKey(DictKeyDto dto)
        {
            if (dto == null) return null;

            var url = $"{service}/v1.0/dicts/{dto.dictId}/keys";
            var client = new HttpClient<string>(url);

            return client.commit(RequestMethod.POST, dto);
        }

        /// <summary>
        /// 编辑字典键值
        /// </summary>
        /// <param name="dto">字典键值DTO</param>
        /// <returns>是否更新成功</returns>
        public bool editDictKey(DictKeyDto dto)
        {
            if (dto == null) return false;

            var url = $"{service}/v1.0/dicts/keys/{dto.id}";
            var client = new HttpClient<object>(url);

            return client.put(dto);
        }

        /// <summary>
        /// 删除字典键值
        /// </summary>
        /// <param name="dto">字典键值DTO</param>
        /// <returns>是否删除成功</returns>
        public bool deleteDictKey(DictKeyDto dto)
        {
            if (dto == null) return false;

            var url = $"{service}/v1.0/dicts/keys/{dto.id}";
            var client = new HttpClient<object>(url);

            return client.delete();
        }
    }
}
