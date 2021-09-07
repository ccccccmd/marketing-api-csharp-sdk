using System;

namespace TencentAd.Model.Common
{
    public class TimeRange
    {
        public TimeRange(long startTime, long endTime)
        {
            start_time = startTime;
            end_time = endTime;
        }

        public TimeRange(DateTime startTime, DateTime endTime)
        {
            start_time = startTime.ToUnixTimeSeconds();
            end_time = endTime.ToUnixTimeSeconds();
        }

        /// <summary>
        ///     开始时间戳，精确到秒，小于 end_time 最小值 0，最大值 9999999999
        /// </summary>
        public long start_time { get; set; }

        /// <summary>
        ///     结束时间戳，精确到秒，大于 start_time 最小值 0，最大值 9999999999
        /// </summary>
        public long end_time { get; set; }
    }
}