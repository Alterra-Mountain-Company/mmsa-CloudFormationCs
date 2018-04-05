using System;
using Newtonsoft.Json;

namespace CloudFormationCs.Resources.CloudWatch
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cw-alarm.html
    /// </summary>
    public class Alarm : Resource
    {
        [Required(false)]
        public Boolean ActionsEnabled { get; set; }

        [Required(false)]
        public StringRef[] AlarmActions { get; set; }

        [Required(false)]
        public StringRef AlarmActions1 { set { this.AlarmActions = new StringRef[] { value }; } }

        [Required(false)]
        public String AlarmDescription { get; set; }

        [Required(false)]
        public String AlarmName { get; set; }

        /// <summary>
        /// GreaterThanThreshold, LessThanThreshold, LessThanOrEqualToThreshold, GreaterThanOrEqualToThreshold
        /// </summary>
        [Required(true)]
        public String ComparisonOperator { get; set; }

        [Required(false)]
        public MetricDimension[] Dimensions { get; set; }

        [JsonIgnore]
        public MetricDimension Dimensions1 { set { this.Dimensions = new MetricDimension[] { value, }; } }

        [Required(false)]
        public string EvaluateLowSampleCountPercentile { get; set; }

        [Required(true)]
        public String EvaluationPeriods { get; set; }

        [Required(false)]
        public string ExtendedStatistic { get; set; }

        [Required(false)]
        public String[] InsufficientDataActions { get; set; }

        [Required(true)]
        public String MetricName { get; set; }

        [Required(true)]
        public String Namespace { get; set; }

        [Required(false)]
        public String[] OKActions { get; set; }

        [Required(true)]
        public String Period { get; set; }

        /// <summary>
        /// Valid Values: SampleCount | Average | Sum | Minimum | Maximum 
        /// </summary>
        [Required(true)]
        public String Statistic { get; set; }

        [Required(true)]
        public String Threshold { get; set; }

        /// <summary>
        /// Valid values: breaching, notBreaching, ignore, missing
        /// </summary>
        [Required(false)]
        public string TreatMissingData { get; set; }

        /// <summary>
        /// Valid Values: Seconds | Microseconds | Milliseconds | Bytes | Kilobytes | Megabytes | Gigabytes | Terabytes | Bits | Kilobits | Megabits | Gigabits | Terabits | Percent | Count | Bytes/Second | Kilobytes/Second | Megabytes/Second | Gigabytes/Second | Terabytes/Second | Bits/Second | Kilobits/Second | Megabits/Second | Gigabits/Second | Terabits/Second | Count/Second | None
        /// </summary>
        [Required(false)]
        public String Unit { get; set; }

        public Alarm()
            : base()
        {
        }

        public Alarm(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
