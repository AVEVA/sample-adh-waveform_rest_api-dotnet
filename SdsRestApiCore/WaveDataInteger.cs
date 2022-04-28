using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace SdsRestApiCore
{
    public class WaveDataInteger
    {
        [Key]
        public int OrderTarget { get; set; }

        public int SinInt { get; set; }

        public int CosInt { get; set; }

        public int TanInt { get; set; }

        public override string ToString()
        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;

            StringBuilder builder = new ();
            builder.Append(cultureInfo, $"OrderTarget: {OrderTarget}");
            builder.Append(cultureInfo, $", SinInt: {SinInt}");
            builder.Append(cultureInfo, $", CosInt: {CosInt}");
            builder.Append(cultureInfo, $", TanInt: {TanInt}");
            return builder.ToString();
        }
    }
}
