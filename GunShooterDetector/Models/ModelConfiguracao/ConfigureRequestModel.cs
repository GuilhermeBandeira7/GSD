using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShooterDetector.Models.ModelConfiguracao
{
    public class ConfigureRequestModel
    {
        public string HEADER = "config";
        public string SN = string.Empty;
        public int MODE; //Configuration mode
        public int INFE; //Inference value
        public int TRL1; //Relay activation timeout
        public int MRL2; //Relay Mode 
        public int TRL2; //Relay activation timeout2
        public int MLED; //Led Operation
        public int GCH1 = 1;
        public int GCH2 = 1;
        public int GSPK = 1;
    }
}
