using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShooterDetector.Models.ModelConfiguracao
{
    class ConfigureResponseModel
    {
        public string HEADER = "configSucess";
        public string SN = string.Empty;
        public int MODE = -1;
        public int INFE = -1;
        public int TRL1 = -1;
        public int MRL2 = -1;
        public int TRL2 = -1;
        public int MLED = -1;
        public int GCH1 = -1;
        public int GCH2 = -1;
        public int GSPK = -1;       
    }
}
