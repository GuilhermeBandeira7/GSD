using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShooterDetector.Models.ModelCalibracao
{
    public class CalibrationChanel2ReqModel
    {
        public string HEADER = "ch2Cal";
        public string SN = string.Empty;
        public int GCL2 = 10; //GANHO 1 A 100
        public int VCL2 = 65; //TENSÃO 0 A 3.300 
        public int TCL2 = 1000; //TEMPO MEDIÇÃO 0 A 10.000 MS
    }
}
