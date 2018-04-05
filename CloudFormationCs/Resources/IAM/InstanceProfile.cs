using System;
using Newtonsoft.Json;

namespace CloudFormationCs.Resources.IAM
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html
    /// </summary>
    public class InstanceProfile : Resource
    {
        [Required(true)]
        public String Path { get; set; }

        [Required(true)]
        public StringRef[] Roles { get; set; }

        [JsonIgnore]
        public StringRef Roles1 { set { this.Roles = new StringRef[] { value }; } }

        public InstanceProfile()
            : base()
        {
        }

        public InstanceProfile(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
