using System;
using Newtonsoft.Json;


namespace CloudFormationCs.Resources.IAM
{
    public class Policy : Resource
    {
        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef[] Groups { get; set; }

        [Required(true)]
        public PolicyDocument PolicyDocument { get; set; }

        [Required(true)]
        public StringRef PolicyName { get; set; }

        [Required(false)]
        public StringRef[] Roles { get; set; }

        [JsonIgnore]
        public StringRef Roles1 { set { this.Roles = new StringRef[] { value }; } }

        [Required(RequiredAttribute.RequirementTypes.Conditional)]
        public StringRef[] Users { get; set; }

        public Policy()
            : base()
        {
        }

        public Policy(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
