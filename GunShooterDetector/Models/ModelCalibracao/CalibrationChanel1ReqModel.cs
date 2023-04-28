using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShooterDetector.Models.ModelCalibracao
{
    public class CalibrationChanel1ReqModel
    {
        public string HEADER = "ch1Cal";
        public string SN = string.Empty;
        public int GCL1 = 10; //GANHO 1 A 100
        public int VCL1 = 65; //TENSÃO 0 A 3.300 
        public int TCL1 = 1000; //TEMPO MEDIÇÃO 0 A 10.000 MS
    }
}
