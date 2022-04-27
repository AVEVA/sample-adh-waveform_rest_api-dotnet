using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace SdsRestApiCore
{
    public class WaveDataTarget
    {
        [Key]
        public int OrderTarget { get; set; }

        public double TauTarget { get; set; }

        public double RadiansTarget { get; set; }

        public double SinTarget { get; set; }

        public double CosTarget { get; set; }

        public double TanTarget { get; set; }

        public double SinhTarget { get; set; }

        public double CoshTarget { get; set; }

        public double TanhTarget { get; set; }

        public override string ToString()
        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            StringBuilder builder = new ();
            _ = builder.Append(cultureInfo, $"OrderTarget: {OrderTarget}");
            _ = builder.Append(cultureInfo, $", RadiansTarget: {RadiansTarget}");
            _ = builder.Append(cultureInfo, $", TauTarget: {TauTarget}");
            _ = builder.Append(cultureInfo, $", SinTarget: {SinTarget}");
            _ = builder.Append(cultureInfo, $", CosTarget: {CosTarget}");
            _ = builder.Append(cultureInfo, $", TanTarget: {TanTarget}");
            _ = builder.Append(cultureInfo, $", SinhTarget: {SinhTarget}");
            _ = builder.Append(cultureInfo, $", CoshTarget: {CoshTarget}");
            _ = builder.Append(cultureInfo, $", TanhTarget: {TanhTarget}");
            return builder.ToString();
        }
    }
}
