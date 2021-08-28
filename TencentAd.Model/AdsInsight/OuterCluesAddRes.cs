namespace TencentAd.Model.AdsInsight
{
    public class OuterCluesAddRes
    {
        /// <summary>
        ///     返回失败的信息列表
        /// </summary>
        public fail_outer_lead_id[] fail_outer_lead_id_list { get; set; }

        /// <summary>
        ///     返回成功的线索列表
        /// </summary>
        public success_lead_id[] success_lead_id_list { get; set; }
    }


    public class fail_outer_lead_id
    {
        /// <summary>
        ///     线索在请求参数中的索引，当请求参数中包含 N 条数据时，每条数据的索引即为
        /// </summary>
        public int index { get; set; }

        /// <summary>
        ///     外部线索 id，作为线索管理平台的线索与客户侧 CRM 系统的线索关联的唯一标识
        /// </summary>
        public string outer_leads_id { get; set; }
    }

    public class success_lead_id
    {
        /// <summary>
        ///     线索在请求参数中的索引，当请求参数中包含 N 条数据时，每条数据的索引即为 0 ～ N-1
        /// </summary>
        public int index { get; set; }

        /// <summary>
        ///     外部线索 id，作为线索管理平台的线索与客户侧 CRM 系统的线索关联的唯一标识
        /// </summary>
        public string outer_leads_id { get; set; }

        /// <summary>
        ///     线索 id
        /// </summary>
        public long leads_id { get; set; }
    }
}