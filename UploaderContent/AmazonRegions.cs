using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UploaderContent
{
    public static class AmazonRegions
    {
        public static string UsEast1 { get; set; } = "us-east-1";

        public static string UsEast2 { get; set; } = "us-east-2";

        public static string UsWest1 { get; set; }="us-west-1";

        public static string UsWest2 { get; set; }="us-west-2";

        public static string CaCentral1 { get; set; }="ca-central-1";

        public static string EuWest1 { get; set; }="eu-west-1";

        public static string EuCentral1 { get; set; }="eu-central-1";

        public static string EuWest2 { get; set; }="eu-west-2";

        public static string EuWest3 { get; set; }="eu-west-3";

        public static string EuNorth1 { get; set; }="eu-north-1";

        public static string ApNortheast1 { get; set; }="ap-northeast-1";

        public static string ApNortheast2 { get; set; }="ap-northeast-2";

        public static string ApSoutheast1 { get; set; }="ap-southeast-1";

        public static string ApSoutheast2 { get; set; }="ap-southeast-2";

        public static string ApSouth1 { get; set; }="ap-south-1";

        public static string SaEast1 { get; set; }="sa-east-1";

        public static string UsGovWest1 { get; set; }="us-gov-west-1";

        public static string UsGovEast1 { get; set; }="us-gov-east-1";

        public static IList List()
        {
            List<string> region = new List<string>();
            region.Add(UsEast1);
            region.Add(UsEast2);
            region.Add(UsWest1);
            region.Add(UsWest2);
            region.Add(CaCentral1);

            return region;
        }
    }


}
