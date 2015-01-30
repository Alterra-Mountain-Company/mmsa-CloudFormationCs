using System;

namespace CloudFormationCs.Entity
{
    public class BlockDeviceMapping
    {
        public String DeviceName { get; set; }

        public Object NoDevice { get; set; }

        public Ebs Ebs { get; set; }

        public String VirtualName { get; set; }

        /// <summary>
        /// BlockDeviceMappings for specifying just the root device size (drive C on windows)
        /// Also specifies gp2 volume type (General Purpose SSD)
        /// </summary>
        /// <param name="sizeInGb"></param>
        /// <returns></returns>
        public static BlockDeviceMapping RootDeviceSizeGp2(int sizeInGb)
        {
            return new BlockDeviceMapping()
            {
                DeviceName = "/dev/sda1",
                Ebs = new Ebs()
                {
                    VolumeSize = sizeInGb,
                    VolumeType = VolumeTypes.gp2,
                },
            };
        }
        public static BlockDeviceMapping RootDeviceGp2()
        {
            return new BlockDeviceMapping()
            {
                DeviceName = "/dev/sda1",
                Ebs = new Ebs()
                {
                    VolumeType = VolumeTypes.gp2,
                },
            };
        }
    }
}

