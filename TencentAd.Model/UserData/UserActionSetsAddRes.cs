namespace TencentAd.Model.UserData
{
    public class UserActionSetsAddRes
    {
        /// <summary>
        ///     用户行为源 id，通过 [user_action_sets 接口] 创建用户行为源时分配的唯一 id。请注意，当填写的用户行为数据源类型为 {WECHAT, WECHAT_MINI_PROGRAM,
        ///     WECHAT_MINI_GAME} 时，必填 user_id 字段中的 wechat_openid (或 wechat_unionid) 及 wechat_app_id。
        /// </summary>
        public long user_action_set_id { get; set; }
    }
}