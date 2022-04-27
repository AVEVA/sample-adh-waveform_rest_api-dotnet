using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace SdsRestApiCore
{
    public class WaveData
    {
        [Key]
        public int Order { get; set; }

        public double Tau { get; set; }

        public double Radians { get; set; }

        public double Sin { get; set; }

        public double Cos { get; set; }

        public double Tan { get; set; }

        public double Sinh { get; set; }

        public double Cosh { get; set; }

        public double Tanh { get; set; }

        public override string ToString()
        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;

            StringBuilder builder = new ();
            _ = builder.Append(cultureInfo, $"Order: {Order}");
            _ = builder.Append(cultureInfo, $", Radians: {Radians}");
            _ = builder.Append(cultureInfo, $", Tau: {Tau}");
            _ = builder.Append(cultureInfo, $", Sin: {Sin}");
            _ = builder.Append(cultureInfo, $", Cos: {Cos}");
            _ = builder.Append(cultureInfo, $", Tan: {Tan}");
            _ = builder.Append(cultureInfo, $", Sinh: {Sinh}");
            _ = builder.Append(cultureInfo, $", Cosh: {Cosh}");
            _ = builder.Append(cultureInfo, $", Tanh: {Tanh}");
            return builder.ToString();
        }
    }
}
