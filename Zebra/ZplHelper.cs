using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.Printing.Zebra
{
  public  class ZplHelper
    {
        #region "Print Settings"
        public static string PrintSpeed { get; set; } = "2";
        public static string Darkness { get; set; } = "0";
        public static string MediaType { get; set; } = "M";
        #endregion

        private static string GetSetupFormat()
        {
            return "^XA" + Environment.NewLine +
            "^PR" + PrintSpeed.ToString() + Environment.NewLine +
            "^MD" + Convert.ToDouble(Darkness) + Environment.NewLine +
            "^MNM";
        }
    }
}
