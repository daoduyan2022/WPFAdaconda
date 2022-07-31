using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaconda.Config
{
    public class Config
    {
        public static string ModelPath = $"{Properties.Settings.Default.APP_CONFIG_PATH}/Models";
        public static string PLCCodePath = $"{Properties.Settings.Default.APP_CONFIG_PATH}/PLC_Code";



    }
}
